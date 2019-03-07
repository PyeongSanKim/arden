using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesOrNo : MonoBehaviour
{
    public int QuestIndex = -1;
    public Text QuestName;
    public Text QuestHuman;
    public Text QuestDesc;
    public Drop2[] ItemSlot;
    public GameObject YES;
    public Inventory inv;
    public void clearCheck()
    {
        for (int i = 0; i < 9; i++)
        {
            if(i==8)
            {
                YES.SetActive(false);
            }
            else if (QuestIndex.Equals(0)&&ItemSlot[i].number == 2)
            {
                YES.SetActive(true);
                break;
            }
        }
    }
    public void yesBtn()
    {
        // Quest인덱스 검사
        //       매대 물품 감소
        //       보상획득
        if(QuestIndex.Equals(0))
        {
            inv.decreseItem(2);
        }

        noBtn(3);
    }
    // 0. 미수락
    // 1. 수락
    // 2. 거절
    // 3. 완료
    public void noBtn(int index)
    {
        gameObject.SetActive(false);
        string Q = "Quest" + QuestIndex;
        GameObject.Find(Q).SetActive(false);
        PlayerPrefs.SetInt(Q, index);
        QuestName.text = "";
        QuestHuman.text = "";
        QuestDesc.text = "";
    }
}
