using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyDialougeSys : MonoBehaviour
{
    public int DiaNum = 0;

    public DialogueTxt DT1;
    public DialogueTxt DT2;
    public DialogueTxt DT3;

    void Start()
    {
        Invoke("Tute", 2f);
    }
    void Tute()
    {
        DT1.DialogueBtn();
    }

    public void SeriaDia()
    {
        DT2.DialogueBtn();
    }


    public void NextDialogue()
    {
        if (DiaNum.Equals(0))
            return;
        else if(DiaNum.Equals(1))
        {
            DT3.DialogueBtn();
        }
    }
}
