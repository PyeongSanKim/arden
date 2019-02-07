using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public GameObject ItemPan;
    public GameObject CollectionPan;
    public GameObject MixturePan;

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
            isItem = false;
            isCollection = false;
            isMixture = false;
        }
        else if(isQuest)
        {
            QuestPan.SetActive(false);
            isQuest = false;
        }
    }
    public void ClickItemBtn()
    {
        if (!isItem)
        {
            AllBtnDown();
            ItemPan.SetActive(true);
            isQuest = false;
            isItem = true;
            isCollection = false;
            isMixture = false;
        }
        else if (isItem)
        {
            ItemPan.SetActive(false);
            isItem = false;
        }
    }
    public void ClickCollectionBtn()
    {
        if (!isCollection)
        {
            AllBtnDown();
            CollectionPan.SetActive(true);
            isQuest = false;
            isItem = false;
            isCollection = true;
            isMixture = false;
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
            MixturePan.SetActive(true);
            isQuest = false;
            isItem = false;
            isCollection = false;
            isMixture = true;
        }
        else if (isMixture)
        {
            MixturePan.SetActive(false);
            isMixture = false;
        }
    }

    void AllBtnDown()
    {
        QuestPan.SetActive(false);
        ItemPan.SetActive(false);
        CollectionPan.SetActive(false);
        MixturePan.SetActive(false);
    }
}
