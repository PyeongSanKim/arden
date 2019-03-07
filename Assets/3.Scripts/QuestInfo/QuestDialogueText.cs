using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDialogueText : MonoBehaviour
{
    public MgrQuest MQ;
    public QuestDialogue dia;

    public void DialogueBtn()
    {
        MQ.StartDialogue(dia);
    }
}
