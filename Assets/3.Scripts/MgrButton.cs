﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MgrButton : MonoBehaviour
{
    public GameObject RightQuestPan;
    public Text QuestName;
    public Text QuestHuman;
    public Text QuestDesc;
    //public Image result;

    public void pressQuestBtn()
    {
        RightQuestPan.SetActive(true);
        QuestName.text = GetComponent<QuestInfo>().QuestData.name;
        QuestHuman.text = GetComponent<QuestInfo>().QuestData.human;
        QuestDesc.text = GetComponent<QuestInfo>().QuestData.desc;
    }
}
