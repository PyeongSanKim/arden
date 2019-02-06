using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MgrDialogue : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    public GameObject DialoguePan;
    private Queue<string> sentences;

    void Awake()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        DialoguePan.SetActive(true);
    	nameText.text = dialogue.name;
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
        DialoguePan.SetActive(false);
    }
}
