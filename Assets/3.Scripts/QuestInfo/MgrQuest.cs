using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MgrQuest : MonoBehaviour
{
    public Text dialogueText;
    public GameObject DialoguePan;
    public Image IMG;

    private Queue<string> sentences;
    private Queue<Sprite> sprites;

    void Awake()
    {
        sentences = new Queue<string>();
        sprites = new Queue<Sprite>();

    }

    public void StartDialogue(QuestDialogue dialogue)
    {
        DialoguePan.SetActive(true);
        sentences.Clear();
        sprites.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach (Sprite sprite in dialogue.sprites)
        {
            sprites.Enqueue(sprite);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        Debug.Log(sentences.Count);

        if (sentences.Count == 0)
        {
            Debug.Log("asd");

            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        IMG.sprite = sprites.Dequeue();
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
