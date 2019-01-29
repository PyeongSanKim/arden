﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MgrLogo : MonoBehaviour
{
    public GameObject logo;
    public GameObject startBtn;
    public GameObject background;
    public GameObject Fade;
    void Start()
    {
        StartCoroutine(CoLogo());
    }

    public void nextSceneBtn()
    {
        Fade.SetActive(true);
        startBtn.SetActive(false);
        StartCoroutine(CoNextSceneBtn());
    }

    IEnumerator CoLogo()
    {
        yield return new WaitForSeconds(1f);
        background.GetComponent<RiseUI>().Rise(100, 5f);

        yield return new WaitForSeconds(4.2f);
        logo.GetComponent<FadeController>().FadeIn(2f, false);
        logo.GetComponent<RiseUI>().Rise(70, 1f);
        yield return new WaitForSeconds(1.5f);
        startBtn.SetActive(true);
    }

    IEnumerator CoNextSceneBtn()
    {
        Fade.GetComponent<FadeController>().FadeIn(1f, false);
        yield return new WaitForSeconds(1f);
        GetComponent<NextScene>().nScene();
    }
}
