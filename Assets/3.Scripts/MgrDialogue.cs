using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MgrDialogue : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Sprite nullSprite;
    public Image IMG;
    public GameObject DialoguePan;
    public LobbyDialougeSys LDS;
    private Queue<string> sentences;
    private int DialogueIndex;
    void Awake()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        DialogueIndex = dialogue.DialougeIndex;
        DialoguePan.SetActive(true);
    	nameText.text = dialogue.name;
        IMG.sprite = dialogue.sprite;
    	sentences.Clear();

    	foreach (string sentence in dialogue.sentences)
    	{
    		sentences.Enqueue(sentence);
    	}
    	DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
    	if (sentences.Count == 0)
    	{
    		EndDialogue();
    		return;
    	}

    	string sentence = sentences.Dequeue();
    	StopAllCoroutines();
    	StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        IMG.sprite = nullSprite;
        DialoguePan.SetActive(false);
        LDS.DiaNum = DialogueIndex;
        LDS.NextDialogue();
    }
}
