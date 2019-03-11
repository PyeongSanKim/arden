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
    public GameObject SlotContents;
    public void clearCheck()
    {
        //for (int i = 0; i < 9; i++)
        //{
        //    /if(i==8)
        //    /{
        //    /    YES.SetActive(false);
        //    /}
        //    /else if (QuestIndex.Equals(0)&&ItemSlot[i].number == 163) // 아이템 인덱스 체크
        //    /{
        //    /    YES.SetActive(true);
        //    /    break; 
        //    /}


        //}
        ItemInfo[] SC = SlotContents.GetComponentsInChildren<ItemInfo>();
        bool[] isItem = new bool[SC.Length];
        int enoughIndex = 0;
        for (int i = 0; i < isItem.Length; i++)
        {
            isItem[i] = false;
        }


        //////////
        if (QuestIndex.Equals(0) && SC.Length >= 2)
        {
            enoughIndex = 2;
            for (int i = 0; i < SC.Length; i++)
            {
                if (SC[i].ItemID == 1 && SC[i].ItemCount >= 1)
                {
                    isItem[0] = true;
                }
                if (SC[i].ItemID == 163 && SC[i].ItemCount >= 1)
                {
                    isItem[1] = true;
                }
            }
        }
        //////////
        for (int i = 0; i < enoughIndex; i++)
        {
            if (isItem[i] == false)
            {
                YES.SetActive(false);
                break;
            }
            else
            {
                YES.SetActive(true);
            }
        }
    }
    public void yesBtn()
    {
        // Quest인덱스 검사
        //       매대 물품 감소
        //       보상획득
        if (QuestIndex.Equals(0))
        {
            inv.decreseItem(163); ////////
        }
        noBtn(6);
    }
    // 0. 미수락
    // 1. 수락
    // 2. 거절
    // 3. 완료
    // 4. 임시수락
    // 5. 임시거절
    // 6. 임시완료
    public void noBtn(int index) // 퀘스트 거절시 여기에 버튼연결해서 2번으로 바꾸기
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
