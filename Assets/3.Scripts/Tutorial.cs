using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public DialogueTxt DT;
    void Start()
    {
        Invoke("Tute", 2f);
    }
    void Tute()
    {
        if (PlayerPrefs.GetInt("tuto", 0).Equals(0))
        {
            DT.DialogueBtn();
        }
    }
}
