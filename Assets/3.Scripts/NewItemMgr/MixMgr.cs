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
        // 믹스버튼
        if (mixSlot[1].number == -1 && mixSlot[2].number == 0 && mixSlot[3].number == -1 &&
            mixSlot[4].number == -1 && mixSlot[5].number == 1 && mixSlot[6].number == -1 &&
            mixSlot[7].number == -1 && mixSlot[8].number == -1 && mixSlot[9].number == -1)
        {
            inv.decreseItem(0);
            inv.decreseItem(1);
            inv.resultItem(2);
            inv.addItem(2);
            inv.ItemCheck();
        }
    }
}