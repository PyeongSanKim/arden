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
    public void noBtn()
    {
        gameObject.SetActive(false);
        string Q = "Quest" + QuestIndex;
        GameObject.Find(Q).SetActive(false);
        PlayerPrefs.SetInt(Q, 0);
        QuestName.text = "";
        QuestHuman.text = "";
        QuestDesc.text = "";
    }
}
