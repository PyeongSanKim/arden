using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public void addItem(int itemID)
    {
        Invetory.instance.GetAnItem(itemID, 1);
    }
}
