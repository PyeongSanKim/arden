using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectRootManager : MonoBehaviour
{
    public int numberOfLeft = 4;
    public Text numberOfLeftText;
    // Start is called before the first frame update
    void Start()
    {
        updateNumberOfLeftText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void updateNumberOfLeftText(){
        numberOfLeftText.text = numberOfLeft.ToString();
    }
}
