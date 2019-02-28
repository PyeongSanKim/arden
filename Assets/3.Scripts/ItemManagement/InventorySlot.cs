using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Text itemCount_Text;
    public int itemID;

    public void Additem(Item _item)
    {
        itemID = _item.itemID;
        icon.sprite = _item.itemIcon;
        if (_item.itemCount > 0)
            itemCount_Text.text = "x " + _item.itemCount.ToString();
        else
        {
            itemCount_Text.text = " ";
            Invetory.instance.invetoryItemList.Remove(_item);
            gameObject.SetActive(false);
        }
    }
    public void RemoveItem()
    {
        icon.sprite = null;
    }
}
