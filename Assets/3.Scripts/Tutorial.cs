using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public int DiaNum = 0;
    public Inventory inv;
    [SerializeField] DialogueTxt DT0;
    [SerializeField] DialogueTxt DT1;
    [SerializeField] DialogueTxt DT2;
    [SerializeField] DialogueTxt DT3;
    [SerializeField] DialogueTxt DT4;
    [SerializeField] DialogueTxt DT5;
    [SerializeField] DialogueTxt DT6;
    [SerializeField] DialogueTxt DT7;
    [SerializeField] DialogueTxt DT8;
    [SerializeField] DialogueTxt DT9;
    [SerializeField] DialogueTxt DT10;
    [SerializeField] DialogueTxt DT11;
    [SerializeField] DialogueTxt DT12;
    [SerializeField] DialogueTxt DT13;
    [SerializeField] DialogueTxt DT14;
    [SerializeField] DialogueTxt DT15;
    [SerializeField] DialogueTxt DT16;
    [SerializeField] DialogueTxt DT17;
    [SerializeField] DialogueTxt DT18;
    [SerializeField] DialogueTxt DT19;
    [SerializeField] DialogueTxt DT20;

    public GameObject Seria;
    public Button QuestBtn;
    public Button ItemBtn;
    public Button CollectBtn;
    public Button MixBtn;

    void Start()
    {
        if(PlayerPrefs.GetInt("tuto").Equals(0))
        {
            Invoke("Tute", 1.5f);
        }
        else
        {
            DiaNum = 20;
            Seria.SetActive(false);
            QuestBtn.interactable = true;
            ItemBtn.interactable = true;
            CollectBtn.interactable = true;
            MixBtn.interactable = true;
        }
    }
    void Update()
    {
        //Debug.Log(DiaNum);
    }
    void Tute()
    {
        DT0.DialogueBtn();
        QuestBtn.interactable = false;
        ItemBtn.interactable = false;
        CollectBtn.interactable = false;
        MixBtn.interactable = false;
        PlayerPrefs.SetInt("Quest1", 1);
        //if (MgrItem.II.Q.Count == 0)
        //{
        //    MgrItem.II.Q.Enqueue(0);
        //}
    }

    public void SeriaDia()
    {
        if (DiaNum.Equals(0))
            DT1.DialogueBtn();
        else if (DiaNum > 4 && DiaNum < 20)
        {
            inv.decreseItem(2);
            DT19.DialogueBtn();
        }
    }
    public void FirstQuestBtn()
    {
        ItemBtn.interactable = true;
        if (DiaNum.Equals(2))
            DT3.DialogueBtn();
    }
    public void FirstItemBtn()
    {
        CollectBtn.interactable = true;
        if (DiaNum.Equals(3))
            DT4.DialogueBtn();
    }
    public void FirstCollectBtn()
    {
        MixBtn.interactable = true;
        if (DiaNum.Equals(4))
            DT5.DialogueBtn();
    }
    public void FirstCityBtn()
    {
        if (DiaNum > 4 && DiaNum< 20)
            DT6.DialogueBtn();
    }
    public void FirstStoreBtn()
    {
        if (DiaNum > 4 && DiaNum < 20)
            DT7.DialogueBtn();
    }
    public void FirstMineBtn()
    {
        if (DiaNum > 4 && DiaNum < 20)
            DT8.DialogueBtn();
    }
    public void FirstMiningBtn()
    {
        if (DiaNum > 4 && DiaNum < 20)
            DT9.DialogueBtn();
    }
    public void FirstGrassBtn()
    {
        if (DiaNum > 4 && DiaNum < 20)
            DT10.DialogueBtn();
    }
    public void FirstGrassGetBtn()
    {
        if (DiaNum > 4 && DiaNum < 20)
            DT11.DialogueBtn();
    }
    public void FirstSlaimeBtn()
    {
        if (DiaNum > 4 && DiaNum < 20)
            DT12.DialogueBtn();
    }
    public void FirstSandBtn()
    {
        if (DiaNum > 4 && DiaNum < 20)
            DT13.DialogueBtn();
    }
    public void FirstSandGetBtn()
    {
        if (DiaNum > 4 && DiaNum < 20)
            DT14.DialogueBtn();
    }
    public void FirstManaBtn()
    {
        if (DiaNum > 4 && DiaNum < 20)
            DT15.DialogueBtn();
    }
    public void FirstManaGetBtn()
    {
        if (DiaNum == 15)
            DT16.DialogueBtn();
    }
    public void FirstmixPanBtn()
    {
        if (DiaNum == 16)
        {
            DT17.DialogueBtn();
        }
    }
    public void  FirstmixBtn()
    {
        if (DiaNum == 17)
        {
            DT18.DialogueBtn();
            Seria.SetActive(true);
        }
    }

    public void NextDialogue()
    {
        if (DiaNum.Equals(0))
            return;
        else if (DiaNum.Equals(1))
        {
            Seria.SetActive(false);
            DT2.DialogueBtn();
            QuestBtn.interactable = true;
        }
        else if (DiaNum.Equals(19))
        {
            Seria.SetActive(false);
            PlayerPrefs.SetInt("tuto", 1);
            DT20.DialogueBtn();
            PlayerPrefs.SetInt("Quest1", 0);
        }
    }
}
