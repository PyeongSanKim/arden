using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    public int ItemID;
    public int ItemCount;
    public Transform itemContents;
    public Transform result;
    public Text CountTxt;

    void Start()
    {
        ItemID = int.Parse(transform.name);
        ItemCheck();
    }

    public void setResult()
    {
        transform.SetParent(result);
    }

    public void itemDown()
    {
        transform.SetParent(itemContents);
    }

    public void ItemCheck()
    {
        if (ItemCount == 0)
        {
            transform.SetParent(itemContents);
            gameObject.SetActive(false);
        }
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
