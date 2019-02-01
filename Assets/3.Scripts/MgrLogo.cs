using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MgrLogo : MonoBehaviour
{
    public GameObject logo;
    public GameObject startBtn;
    public GameObject background;
    public GameObject Fade;
    [Header("Background")]
    public int backRiseNum = 100;
    public float backRriseTime = 5f;

    [Header("Logo")]
    public int logoRiseNum = 70;
    public float logoRiseTime = 1f;

    void Start()
    {
        StartCoroutine(CoLogo());
        Screen.SetResolution(1080, 1920, true);
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
        background.GetComponent<RiseUI>().Rise(backRiseNum, backRriseTime);

        yield return new WaitForSeconds(3f);
        logo.GetComponent<FadeController>().FadeIn(2f, false);
        logo.GetComponent<RiseUI>().Rise(logoRiseNum, logoRiseTime);
        yield return new WaitForSeconds(2.5f);
        startBtn.SetActive(true);
    }

    IEnumerator CoNextSceneBtn()
    {
        Fade.GetComponent<FadeController>().FadeIn(1f, false);
        yield return new WaitForSeconds(1f);
        GetComponent<NextScene>().nScene();
    }
}
