using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public int DiaNum = 0;

    public DialogueTxt DT0;
    public DialogueTxt DT1;
    public DialogueTxt DT2;
    public DialogueTxt DT3;
    public DialogueTxt DT4;
    public DialogueTxt DT5;

    public GameObject Seria;
    public Button QuestBtn;
    public Button ItemBtn;
    public Button CollectBtn;
    public Button MixBtn;

    void Start()
    {
        Invoke("Tute", 2f);
    }
    void Update()
    {
        //Debug.Log(DiaNum);
    }
    void Tute()
    {
        DT0.DialogueBtn();
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
