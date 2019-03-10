using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDialogueText : MonoBehaviour
{
    [Header("없음 0/시작 1/수락 2/거절 3/완료 4")]
    public int QuestDig;
    [Header("퀘스트 번호")]
    public int QuestIndex;
    public MgrQuest MQ;

    [Header("대화 순서대로 기입하시오")]
    public QuestDialogue dia;

    public void DialogueBtn()
    {
        MQ.StartDialogue(dia,QuestIndex,QuestDig);
    }
}
