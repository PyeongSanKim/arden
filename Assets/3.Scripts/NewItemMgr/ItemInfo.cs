using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    public int ItemID;
    public int ItemCount;

    public Text CountTxt;

    void Start()
    {
        ItemID = int.Parse(transform.name);
        ItemCheck();
    }

    public void ItemCheck()
    {
        if (ItemCount == 0)
            gameObject.SetActive(false);
        else if(ItemCount==1)
        {
            gameObject.SetActive(true);
            CountTxt.text = " ";
        }
        else
        {
            gameObject.SetActive(true);
            CountTxt.text = "x " + ItemCount;
        }
    }
}
