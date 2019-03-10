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
    public Text numberOfLeftText;
    public Text rootValueText;
    public Text playerValueText;
    public Text totalPlayerValueText;
    private int totalPlayerValue;
    
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
        generatePlayerValue(power);
        totalPlayerValue += playerValue;
        numberOfLeft--;
        updateNumberOfLeftText();
        updatePlayerValue();
        updateTotalPlayerValue();
    }
    
    private void generatePlayerValue(string power)
    {
        switch (power)
        {
            case "weak":
                playerValue = Random.Range(5, 10);
                break;
            case "normal":
                playerValue = Random.Range(13, 23);
                break;
            case "strong":
                playerValue = Random.Range(25, 30);
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
