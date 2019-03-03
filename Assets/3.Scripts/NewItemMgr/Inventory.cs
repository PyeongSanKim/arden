using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int ItemSize;
    public ItemInfo[] itemList;
    public GameObject resultPan;

    public void addItem(int itemID)
    {
        itemList[itemID].ItemCount++;
        itemList[itemID].ItemCheck();
    }
    public void decreseItem(int itemID)
    {
        itemList[itemID].ItemCount--;
        itemList[itemID].ItemCheck();
    }
    //public void resultItem(int itemID)
    //{
    //    if(resultPan.transform.childCount != 0)
    //    {
    //        resultPan.GetComponentInChildren<ItemInfo>().itemDown();
    //    }
    //}

    public void ItemCheck()
    {
        for(int i=0;i<ItemSize;i++)
        {
            itemList[i].ItemCheck();
        }
    }

    public void allItemDown()
    {
        for (int i = 0; i < ItemSize; i++)
        {
            itemList[i].itemDown();
        }
    }
}
