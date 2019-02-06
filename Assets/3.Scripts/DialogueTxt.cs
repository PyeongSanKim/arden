using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTxt : MonoBehaviour
{
    public Dialogue dia;

    public void DialogueBtn()
    {
        GetComponent<MgrDialogue>().StartDialogue(dia);
    }
}
