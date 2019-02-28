using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixBtn : MonoBehaviour
{
    public GameObject[] DSlot;
    public Transform ItemContents;
    public void MBtn()
    {
        if(DSlot[2].GetComponent<Drop>().number==1021 && DSlot[5].GetComponent<Drop>().number==1023)
        {
            ItemRemove();
            Invetory.instance.GetAnItem(1022,1);
        }
    }

    void ItemRemove()
    {
        Invetory.instance.RemoveItem(1021);
        Invetory.instance.RemoveItem(1023);
    }
}
