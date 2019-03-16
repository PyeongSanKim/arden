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
    public GameObject failedText;
    public GameObject endPanel;
    public GameObject reallyPanel;

    private static collectRootManager instance;

    public static collectRootManager Instance
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

    void Start()
    {
        numberOfLeft = 6;
        endPanel.SetActive(false);
        reallyPanel.SetActive(false);
        failedText.GetComponent<Text>().enabled = false;
        updateNumberOfLeftText();
        setRootValue();
        rootProgressBar.Instance.setRootValue(rootValue);
        totalPlayerValue = 0;
    }
    
    public void clickCollectBtnWith(string power)
    {
        if (numberOfLeft <= 0)
        {
            return;
        }
        
        generatePlayerValueWith(power);
        totalPlayerValue += playerValue;
        
        StartCoroutine(rootProgressBar.Instance.moveProgressBarWith(playerValue));
        
        updateForTest();
        
        if (totalPlayerValue > rootValue + ((rootValue * 12) / 100))
        {
            failedCollectingWithOverPower();
            return;
        }

        numberOfLeft--;
        updateNumberOfLeftText();
    }

    public void clickFinishYes()
    {
        reallyPanel.SetActive(false);
        checkRewards();
    }
    
    public void clickFinishNo()
    {
        reallyPanel.SetActive(false);
    }

    public void clickFinishBtn()
    {
        if (numberOfLeft <= 0)
        {
            checkRewards();
            return;
        }

        if (numberOfLeft > 0)
        {
            reallyPanel.SetActive(true);
        }
    }

    public void checkRewards()
    {
        if (totalPlayerValue == rootValue)
        {
            // 최고 보상
            clearCollectionWith(1);
            return;
        }

        if (totalPlayerValue <= rootValue + ((rootValue * 7) / 100) && totalPlayerValue >= rootValue - ((rootValue * 7) / 100))
        {
            // 2번째 보상
            clearCollectionWith(2);
            return;
        }
        
        if (totalPlayerValue <= rootValue + ((rootValue * 12) / 100) && totalPlayerValue >= rootValue - ((rootValue * 12) / 100))
        {
            // 3번째 보상
            clearCollectionWith(3);
            return;
        }
        
        endPanel.SetActive(true);
        failedText.GetComponent<Text>().enabled = true;
        failedText.GetComponent<Text>().text = "너무 얕게 팠어요!\n채집 실패!";
    }
    
    private void generatePlayerValueWith(string power)
    {
        switch (power)
        {
            case "weak":
                playerValue = Random.Range(2, 10);
                break;
            case "normal":
                playerValue = Random.Range(11, 20);
                break;
            case "strong":
                playerValue = Random.Range(21, 32);
                break;
        }
    }

    private void failedCollectingWithOverPower()
    {
        endPanel.SetActive(true);
        Time.timeScale = 0;
        failedText.GetComponent<Text>().enabled = true;
        failedText.GetComponent<Text>().text = "이런! 뿌리가 손상되버렸어요!\n채집 실패!";
    }

    private void clearCollectionWith(int rank)
    {
        endPanel.SetActive(true);
        Time.timeScale = 0;
        failedText.GetComponent<Text>().enabled = true;
        
        switch (rank)
        {
            case 1:
                failedText.GetComponent<Text>().text = "축하합니다!!\n1등!";
                break;
            case 2:
                failedText.GetComponent<Text>().text = "축하합니다!!\n2등!";
                break;
            case 3:
                failedText.GetComponent<Text>().text = "축하합니다!!\n3등!";
                break;
        }
    }

    void updateForTest()
    {
        updatePlayerValue();
        updateTotalPlayerValue();
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
