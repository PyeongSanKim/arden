using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{
    // 화면이 어두워진다.
    public void FadeIn(float time,bool isBlack)
    {
        StartCoroutine(CoFadeIn(time,isBlack));
    }

    // 화면이 밝아진다.
    public void FadeOut(float time, bool isBlack)
    {
        StartCoroutine(CoFadeOut(time,isBlack));
    }

    IEnumerator CoFadeIn(float time, bool isBlack)
    {
        Color tempColor;
        if (isBlack)
        {
            tempColor = new Color(0, 0, 0, 0);
        }
        else
        {
            tempColor = new Color(1, 1, 1, 0);
        }
        Image img = GetComponent<Image>();
        img.color = tempColor;

        while (tempColor.a < 1f)
        {
            tempColor.a += Time.deltaTime / time;
            img.color = tempColor;

            if (tempColor.a >= 1f)
                tempColor.a = 1f;
            yield return null;
        }
        img.color = tempColor;
    }

    IEnumerator CoFadeOut(float time,bool isBlack)
    {
        Color tempColor;
        if (isBlack)
        {
            tempColor = new Color(0, 0, 0, 1);
        }
        else
        {
            tempColor = new Color(1, 1, 1, 1);
        }
        Image img = GetComponent<Image>();
        img.color = tempColor;

        while (tempColor.a > 0f)
        {
            tempColor.a -= Time.deltaTime / time;
            img.color = tempColor;

            if (tempColor.a <= 0f)
                tempColor.a = 0f;
            yield return null;
        }
        img.color = tempColor;
    }
}