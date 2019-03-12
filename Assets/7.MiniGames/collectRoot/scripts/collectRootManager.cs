using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class collectRootManager : MonoBehaviour
{
    [SerializeField]private int numberOfLeft = 4;
    private int rootValue;
    private int playerValue;
    private int totalPlayerValue;
    
    public Text numberOfLeftText;
    public Text rootValueText;
    public Text playerValueText;
    public Text totalPlayerValueText;
    public GameObject failedTextPower;
    public GameObject failedTextTrial;
    
    void Start()
    {
        updateNumberOfLeftText();
        setRootValue();
        totalPlayerValue = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void clickCollectBtnWith(string power)
    {   
        generatePlayerValueWith(power);
        totalPlayerValue += playerValue;
        Debug.Log(rootValue);
        Debug.Log((rootValue * 12) / 100);
        if (totalPlayerValue >= rootValue + ((rootValue * 12) / 100))
        {
            failedCollectingWith("overPower");
        }
        
        numberOfLeft--;
        if (numberOfLeft <= 0)
        {
            failedCollectingWith("overTrial");
        }
        
        updateNumberOfLeftText();
        updatePlayerValue();
        updateTotalPlayerValue();
    }
    
    private void generatePlayerValueWith(string power)
    {
        switch (power)
        {
            case "weak":
                playerValue = Random.Range(2, 10);
                break;
            case "normal":
                playerValue = Random.Range(13, 18);
                break;
            case "strong":
                playerValue = Random.Range(22, 34);
                break;
        }
        
    }

    private void failedCollectingWith(string reason)
    {
        switch (reason)
        {
            case "overPower":
                Debug.Log("overPower");
                failedTextPower.GetComponent<Text>().enabled = true;
                break;
            case "overTrial":
                Debug.Log("overTrial");
                failedTextTrial.GetComponent<Text>().enabled = true;
                break;
        }
    }

    void setRootValue()
    {
        rootValue = Random.Range(60, 100);
        updateRootValue();
    }

    void updateRootValue()
    {
        rootValueText.text =  "ROOT\n" + rootValue.ToString();
    }

    void updatePlayerValue()
    {
        playerValueText.text = playerValue.ToString();
    }

    void updateTotalPlayerValue()
    {
        totalPlayerValueText.text = totalPlayerValue.ToString();
    }

    void updateNumberOfLeftText()
    {
        numberOfLeftText.text = numberOfLeft.ToString();
    }
}
