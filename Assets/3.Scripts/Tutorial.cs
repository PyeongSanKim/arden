using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public int DiaNum = 0;

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

    public GameObject Seria;
    public Button QuestBtn;
    public Button ItemBtn;
    public Button CollectBtn;
    public Button MixBtn;

    void Start()
    {
        Invoke("Tute", 1.5f);
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
        if (MgrItem.II.Q.Count == 0)
        {
            MgrItem.II.Q.Enqueue(0);
        }
    }

    public void SeriaDia()
    {
        DT1.DialogueBtn();
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
        if (DiaNum > 4)
            DT6.DialogueBtn();
    }
    public void FirstStoreBtn()
    {
        if (DiaNum > 4)
            DT7.DialogueBtn();
    }
    public void FirstMineBtn()
    {
        if (DiaNum > 4)
            DT8.DialogueBtn();
    }
    public void FirstMiningBtn()
    {
        if (DiaNum > 4)
            DT9.DialogueBtn();
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
