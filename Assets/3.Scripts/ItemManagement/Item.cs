using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Item : MonoBehaviour
{
    public int itemID; // 아이템의 고유 ID
    public string itemName;
    public string itemDescription;
    public int itemCount;
    public Sprite itemIcon;
    public ItemType itemType;

    public enum ItemType
    {
        Use, Equip, Quest, ETC
    }

    public Item(int _itemID, string _itemName, string _itemDes, ItemType _itemType, int _itemCount = 1)
    {
        itemID = _itemID;
        itemName = _itemName;
        itemDescription = _itemDes;
        itemType = _itemType;
        itemCount = _itemCount;
        itemIcon = Resources.Load("ItemIcon/" + _itemID.ToString(), typeof(Sprite)) as Sprite;
    }
}
