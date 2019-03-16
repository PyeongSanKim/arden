using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MgrQuest : MonoBehaviour
{
    public Text dialogueText;
    public GameObject DialoguePan;
    public GameObject AcceptPan;
    public GameObject AcceptPan2;
    public Image IMG;
    public Text nameTxt;
    private Queue<string> sentences;
    private Queue<string> names;
    private Queue<Sprite> sprites;

    int QD;
    int QI;

    // PlayerPrefs => QuestX
    // -1. 가능
    // 0. 미수락
    // 1. 수락
    // 2. 거절
    // 3. 완료

    void Awake()
    {
        sentences = new Queue<string>();
        sprites = new Queue<Sprite>();
        names = new Queue<string>();

    }

    public void StartDialogue(QuestDialogue dialogue,int QuestIndex,int QuestDig)
    {
        QD = QuestDig;
        QI = QuestIndex;
        DialoguePan.SetActive(true);
        sentences.Clear();
        sprites.Clear();
        names.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach (Sprite sprite in dialogue.sprites)
        {
            sprites.Enqueue(sprite);
        }
        foreach (string name in dialogue.name)
        {
            names.Enqueue(name);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        Debug.Log(sentences.Count);

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        IMG.sprite = sprites.Dequeue();
        nameTxt.text = names.Dequeue();

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
        if (QD == 1)
        {
            AcceptPan.SetActive(true);
        }
        else if (QD == 2 || QD == 3)
        {
            PlayerPrefs.SetInt("Quest" + QI + "X",1);
        }
    }

    public void Pan1No()
    {
        AcceptPan2.SetActive(true);
    }
    public void Pan1Yes()
    {
        PlayerPrefs.SetInt("Quest" + QI, 4);
        AcceptPan2.SetActive(false);
        AcceptPan.SetActive(false);
    }
    public void Pan2No()
    {
        PlayerPrefs.SetInt("Quest" + QI, 5);
        AcceptPan2.SetActive(false);
        AcceptPan.SetActive(false);
    }
    public void Pan2Yes()
    {
        AcceptPan2.SetActive(false);
    }
}
