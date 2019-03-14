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
    int Gold;


    public void clearCheck()
    {
        YES.SetActive(false);
        ItemInfo[] SC = SlotContents.GetComponentsInChildren<ItemInfo>();
        bool[] isItem = new bool[SC.Length];
        int enoughIndex = 0;
        for (int i = 0; i < isItem.Length; i++)
        {
            isItem[i] = false;
        }


        ////////// 여기 부분을 수정 /////////////
        if (QuestIndex.Equals(0) && SC.Length >= 1) // 퀘스트 인덱스,재료수
        {
            enoughIndex = 1;
            for (int i = 0; i < SC.Length; i++)
            {
                if (SC[i].ItemID == 163 && SC[i].ItemCount >= 1)
                {
                    isItem[0] = true;
                }
            }
        }

        if (QuestIndex.Equals(1) && SC.Length >= 3)
        {
            enoughIndex = 3;
            for (int i = 0; i < SC.Length; i++)
            {
                if (SC[i].ItemID == 25 && SC[i].ItemCount >= 1)
                {
                    isItem[0] = true;
                }
                if (SC[i].ItemID == 155 && SC[i].ItemCount >= 3)
                {
                    isItem[1] = true;
                }
                if (SC[i].ItemID == 126 && SC[i].ItemCount >= 1)
                {
                    isItem[2] = true;
                }
            }
        }
        ///////////////////////////////////////////
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


        ////////// 여기 부분을 수정 /////////////
        if (QuestIndex.Equals(0))
        {
            inv.decreseItem(163); 
        }
        if (QuestIndex.Equals(1))
        {
            inv.decreseItem(25);
            inv.decreseItem(155);
            inv.decreseItem(155);
            inv.decreseItem(155);
            inv.decreseItem(126);
            Gold = PlayerPrefs.GetInt("Gold");
            Gold += 100;
            PlayerPrefs.SetInt("Gold", Gold);
        }
        ///////////////////////////////////////////

        noBtn(6);
    }
    // -1. 수락가능
    // 0. 미수락 (디폴트)
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
