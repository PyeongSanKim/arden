using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixMgr : MonoBehaviour
{
    public Drop[] mixSlot;
    Inventory inv;

    void Start()
    {
        inv = GetComponent<Inventory>();
    }

    public void mixBtn()
    {
        if (mixSlot[2].number == 0 && mixSlot[5].number == 1)
        {
            inv.decreseItem(0);
            inv.decreseItem(1);
            inv.addItem(2);
            inv.ItemCheck();
        }
    }
}