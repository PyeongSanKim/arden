using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetGold : MonoBehaviour
{
    public Text goldText;
    void Update()
    {
        goldText.text = PlayerPrefs.GetInt("Gold",0).ToString();
    }
}
