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
    public GameObject[] NPC;
    public NPC_Quest NQ;

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
                if (SC[i].ItemID == 2 && SC[i].ItemCount >= 1)
                {
                    isItem[0] = true;
                }
                if (SC[i].ItemID == 28 && SC[i].ItemCount >= 3)
                {
                    isItem[1] = true;
                }
                if (SC[i].ItemID == 59 && SC[i].ItemCount >= 1)
                {
                    isItem[2] = true;
                }
            }
        }

        if (QuestIndex.Equals(2) && SC.Length >= 2)
        {
            enoughIndex = 2;
            for (int i = 0; i < SC.Length; i++)
            {
                if (SC[i].ItemID == 83 && SC[i].ItemCount >= 1)
                {
                    isItem[0] = true;
                }
                if (SC[i].ItemID == 139 && SC[i].ItemCount >= 1)
                {
                    isItem[1] = true;
                }
            }
        }

        if (QuestIndex.Equals(3) && SC.Length >= 3)
        {
            enoughIndex = 3;
            for (int i = 0; i < SC.Length; i++)
            {
                if (SC[i].ItemID == 152 && SC[i].ItemCount >= 3)
                {
                    isItem[0] = true;
                }
                if (SC[i].ItemID == 178 && SC[i].ItemCount >= 3)
                {
                    isItem[1] = true;
                }
                if (SC[i].ItemID == 5 && SC[i].ItemCount >= 2)
                {
                    isItem[1] = true;
                }
            }
        }
        if (QuestIndex.Equals(4) && SC.Length >= 3)
        {
            enoughIndex = 3;
            for (int i = 0; i < SC.Length; i++)
            {
                if (SC[i].ItemID == 103 && SC[i].ItemCount >= 5)
                {
                    isItem[0] = true;
                }
                if (SC[i].ItemID == 62 && SC[i].ItemCount >= 5)
                {
                    isItem[1] = true;
                }
                if (SC[i].ItemID == 16 && SC[i].ItemCount >= 10)
                {
                    isItem[1] = true;
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
            Gold = PlayerPrefs.GetInt("Gold");
            Gold += 100;
            PlayerPrefs.SetInt("Gold", Gold);
            PlayerPrefs.SetInt("Quest1", -1);
        }

        if (QuestIndex.Equals(1))
        {
            inv.decreseItem(2);
            inv.decreseItem(28);
            inv.decreseItem(59);
            Gold = PlayerPrefs.GetInt("Gold");
            Gold += 400;
            PlayerPrefs.SetInt("Gold", Gold);
        }
        if (QuestIndex.Equals(2))
        {
            inv.decreseItem(83);
            inv.decreseItem(139);
            Gold = PlayerPrefs.GetInt("Gold");
            Gold += 500;
            PlayerPrefs.SetInt("Gold", Gold);
        }
        if (QuestIndex.Equals(3))
        {
            inv.decreseItem(152);
            inv.decreseItem(152);
            inv.decreseItem(152);
            inv.decreseItem(178);
            inv.decreseItem(178);
            inv.decreseItem(178);
            inv.decreseItem(5);
            inv.decreseItem(5);
            Gold = PlayerPrefs.GetInt("Gold");
            Gold += 100;
            PlayerPrefs.SetInt("Gold", Gold);
        }
        if (QuestIndex.Equals(4))
        {
            for (int i = 0; i < 5; i++)
            {
                inv.decreseItem(103);
                inv.decreseItem(62);
                inv.decreseItem(16);
            }
            for (int i = 0; i < 5; i++)
            {
                inv.decreseItem(16);
            }
            Gold = PlayerPrefs.GetInt("Gold");
            Gold += 3000;
            PlayerPrefs.SetInt("Gold", Gold);
        }

        //덥스용
        //if (QuestIndex.Equals(1))
        //{
        //    inv.decreseItem(25);
        //    inv.decreseItem(155);
        //    inv.decreseItem(155);
        //    inv.decreseItem(155);
        //    inv.decreseItem(126);
        //    Gold = PlayerPrefs.GetInt("Gold");
        //    Gold += 100;
        //    PlayerPrefs.SetInt("Gold", Gold);
        //}
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

        if (QuestIndex.Equals(1))
        {
            PlayerPrefs.SetInt("Quest2", -1);
        }
        else if (QuestIndex.Equals(2))
        {
            PlayerPrefs.SetInt("Quest3", -1);
            PlayerPrefs.SetInt("Quest4", -1);
        }
        NQ.NPCCheck();
    }
}
