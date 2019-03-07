using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public int DiaNum = 0;
    public Inventory inv;
    public MixMgr MM;
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
    [SerializeField] DialogueTxt DT21;
    [SerializeField] DialogueTxt DT22;

    public GameObject Seria;
    public Button QuestBtn;
    public Button ItemBtn;
    public Button CollectBtn;
    public Button MixBtn;

    void Start()
    {
        if(PlayerPrefs.GetInt("tuto").Equals(0)){
            Invoke("Tute", 1.5f);
        }
        else {
            DiaNum = 22;
            Seria.SetActive(false);
            QuestBtn.interactable = true;
            ItemBtn.interactable = true;
            CollectBtn.interactable = true;
            MixBtn.interactable = true;
        }
    }
    void Update(){
        if (DiaNum.Equals(19) && PlayerPrefs.GetInt("itemtuto").Equals(1))
        {
            PlayerPrefs.SetInt("itemtuto", 0);
            DT20.DialogueBtn();
        }
    }
    void Tute()
    {
        DT0.DialogueBtn();
        QuestBtn.interactable = false;
        ItemBtn.interactable = false;
        CollectBtn.interactable = false;
        MixBtn.interactable = false;
        PlayerPrefs.SetInt("Quest0", 1);
        //if (MgrItem.II.Q.Count == 0)
        //{
        //    MgrItem.II.Q.Enqueue(0);
        //}
    }

    public void SeriaDia()
    {
        if (DiaNum.Equals(0))
            DT1.DialogueBtn();
        //else if (DiaNum > 4 && DiaNum < 22)
        //{
        //    inv.decreseItem(2);
        //}
    }

    public void FirstQuestBtn()
    {
        ItemBtn.interactable = true;
        if (DiaNum.Equals(2))
            DT3.DialogueBtn();
        else if (DiaNum.Equals(20))
        {
            DT21.DialogueBtn();
        }
    }
    public void FirstItemBtn()
    {
        CollectBtn.interactable = true;
        if (DiaNum.Equals(3))
            DT4.DialogueBtn();
        else if (DiaNum.Equals(18))
        {
            PlayerPrefs.SetInt("itemtuto", 0);
            DT19.DialogueBtn();
        }
    }
    public void FirstCollectBtn()
    {
        MixBtn.interactable = true;
        if (DiaNum.Equals(4))
            DT5.DialogueBtn();
    }
    public void FirstCityBtn()
    {
        if (DiaNum > 4 && DiaNum< 16)
            DT6.DialogueBtn();
    }
    public void FirstStoreBtn()
    {
        if (DiaNum > 4 && DiaNum < 16)
            DT7.DialogueBtn();
    }
    public void FirstMineBtn()
    {
        if (DiaNum > 4 && DiaNum < 16)
            DT8.DialogueBtn();
    }
    public void FirstMiningBtn()
    {
        if (DiaNum > 4 && DiaNum < 16)
            DT9.DialogueBtn();
    }
    public void FirstGrassBtn()
    {
        if (DiaNum > 4 && DiaNum < 16)
            DT10.DialogueBtn();
    }
    public void FirstGrassGetBtn()
    {
        if (DiaNum > 4 && DiaNum < 16)
            DT11.DialogueBtn();
    }
    public void FirstSlaimeBtn()
    {
        if (DiaNum > 4 && DiaNum < 16)
            DT12.DialogueBtn();
    }
    public void FirstSandBtn()
    {
        if (DiaNum > 4 && DiaNum < 16)
            DT13.DialogueBtn();
    }
    public void FirstSandGetBtn()
    {
        if (DiaNum > 4 && DiaNum < 16)
            DT14.DialogueBtn();
    }
    public void FirstManaBtn()
    {
        if (DiaNum > 4 && DiaNum < 16)
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
        if (DiaNum == 17 && MM.mixItemIndex==2)
        {
            DT18.DialogueBtn();
        }
    }
    public void endTuto()
    {
        if (DiaNum == 21&&PlayerPrefs.GetInt("tuto").Equals(0))
        {
            DT22.DialogueBtn();
            PlayerPrefs.SetInt("tuto", 1);
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
    }
}
