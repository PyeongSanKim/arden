﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptQuest : MonoBehaviour
{
    public int AQindex;
    public GameObject QuestItem;
    public QuestDialogueText AcceptQDT;
    public QuestDialogueText refuseQDT;
    public QuestDialogueText CompleteQDT;
    public GameObject childNPC;
    void Update()
    {
        if (PlayerPrefs.GetInt("Quest" + AQindex).Equals(4))
        {
            PlayerPrefs.SetInt("Quest" + AQindex, 1);
            QuestItem.SetActive(true);
            AcceptQDT.DialogueBtn();
        }
        else if (PlayerPrefs.GetInt("Quest" + AQindex).Equals(5))
        {
            PlayerPrefs.SetInt("Quest" + AQindex, 2);
            refuseQDT.DialogueBtn();
        }
        else if (PlayerPrefs.GetInt("Quest" + AQindex).Equals(6))
        {
            PlayerPrefs.SetInt("Quest" + AQindex, 3);
            CompleteQDT.DialogueBtn();
            childNPC.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Quest" + AQindex + "X").Equals(1))
        {
            PlayerPrefs.SetInt("Quest" + AQindex + "X", 0);
            childNPC.gameObject.SetActive(false);
        }
    }
}