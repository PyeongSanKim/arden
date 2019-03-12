using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rootProgressBar : MonoBehaviour
{
    private Image progressBar;
    private int totalPlayerValue;
    private float rootValue;
    
    private static rootProgressBar instance;

    public static rootProgressBar Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    private void Start()
    {
        progressBar = GetComponent<Image>();
        progressBar.fillAmount = 0;
    }

    public IEnumerator moveProgressBarWith(int clickedPlayerValue)
    {
        float speed = 0.5f;
        totalPlayerValue += clickedPlayerValue;
        float previousTotalPlayerValue = totalPlayerValue - clickedPlayerValue;

        float t = previousTotalPlayerValue;
        
        while (t < totalPlayerValue)
        {
            t += speed;
            progressBar.fillAmount = t / rootValue;
            yield return null;
        }
    }

    public void setRootValue(int rootValue)
    {
        this.rootValue = (float)rootValue;
    }
}
