﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MgrLobby : MonoBehaviour
{
    public GameObject Pan_statusD;
    bool isPan_statusD = false;
    public GameObject Fade;


    public GameObject MixturePan;
    bool isMixture = false;


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

    public void ClickMixtureBtn()
    {
        if(!isMixture)
        {
            MixturePan.SetActive(true);
            isMixture = true;
        }
        else if(isMixture)
        {
            MixturePan.SetActive(false);
            isMixture = false;
        }
    }
}
