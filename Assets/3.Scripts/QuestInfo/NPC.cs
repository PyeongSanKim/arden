using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //[Header("NPC이름")]
    //public string name;

    // if(QuestIndex.Equals(해당넘버)) 인경우 알맞는 다이얼로그 출력
    // 첫 다이얼로그 끝날시 수락 / 거절 패널 생성
    // PlayerPrafs.SetInt(QuestX) 로 설정
    // 두번째 다이얼로그 => 수락
    // 세번째 다이얼로그 => 거절
    // -------------- 구해오기 -------------
    // 네번째 다이얼로그 => 완료
    // PlayerPrafs.SetInt(QuestX) 로 설정
    [Header("시작 QDT")]
    public QuestDialogueText QDT;

    public void OnNPCBtn(int QuestIndex)
    {
        if (QuestIndex.Equals(1))
        {
            QDT.DialogueBtn();
        }
    }
}
