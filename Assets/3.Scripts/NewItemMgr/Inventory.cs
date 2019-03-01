using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int ItemSize;
    public ItemInfo[] itemList;

    public void addItem(int itemID)
    {
        itemList[itemID].ItemCount++;
    }
    public void decreseItem(int itemID)
    {
        itemList[itemID].ItemCount--;
    }

    public void ItemCheck()
    {
        Debug.Log(ItemSize);
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
