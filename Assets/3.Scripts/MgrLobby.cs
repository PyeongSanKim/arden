using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MgrLobby : MonoBehaviour
{
    public GameObject Pan_statusD;
    bool isPan_statusD = false;
    public GameObject Fade;

    bool isQuest = false;
    bool isItem = false;
    bool isCollection = false;
    bool isMixture = false;
    public GameObject QuestPan;
    public GameObject ItemPanAll;
    public GameObject CollectionPan;
    public GameObject ItemPan;
    public GameObject MixPan;

    public Text QuestName;
    public Text QuestHuman;
    public Text QuestDesc;

    void Start()
    {
        Fade.GetComponent<FadeController>().FadeOut(2f, false);
    }

    // 분야별 레벨버튼 클릭시
    public void ClickbLevelBtn()
    {
        if (!isPan_statusD)
        {
            isPan_statusD = true;
            Pan_statusD.SetActive(true);
        }
        else
        {
            isPan_statusD = false;
            Pan_statusD.SetActive(false);
        }
    }

    public void ClickQuestBtn()
    {
        if(!isQuest)
        {
            AllBtnDown();
            QuestPan.SetActive(true);
            isQuest = true;
        }
        else if(isQuest)
        {
            QuestPan.SetActive(false);
            isQuest = false;
        }
        QuestName.text = "";
        QuestHuman.text = "";
        QuestDesc.text = "";

    }
    public void ClickItemBtn()
    {
        if (!isItem)
        {
            AllBtnDown();
            ItemPanAll.SetActive(true);
            ItemPan.SetActive(true);
            MixPan.SetActive(false);
            isItem = true;
        }
        else if (isItem)
        {
            ItemPanAll.SetActive(false);
            isItem = false;
        }
    }
    public void ClickCollectionBtn()
    {
        if (!isCollection)
        {
            AllBtnDown();
            CollectionPan.SetActive(true);
            isCollection = true;
        }
        else if (isCollection)
        {
            CollectionPan.SetActive(false);
            isCollection = false;
        }
    }
    public void ClickMixtureBtn()
    {
        if (!isMixture)
        {
            AllBtnDown();
            ItemPanAll.SetActive(true);
            ItemPan.SetActive(false);
            MixPan.SetActive(true);
            isMixture = true;
        }
        else if (isMixture)
        {
            ItemPanAll.SetActive(false);
            isMixture = false;
        }
    }

    public void AllBtnDown()
    {
        QuestPan.SetActive(false);
        ItemPanAll.SetActive(false);
        CollectionPan.SetActive(false);
        isQuest = false;
        isItem = false;
        isCollection = false;
        isMixture = false;
    }
}
