using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MixMgr : MonoBehaviour
{
    public Drop[] mixSlot;
    Inventory inv;
    public Image IMG;
    public Sprite nul;
    public int mixItemIndex;

    void Update()
    {
        if(mixItemIndex==-1)
            IMG.sprite = nul;
    }

    void OnEnable()
    {
        Debug.Log("hi");
    }

    void Start()
    {
        inv = GetComponent<Inventory>();
    }

    public void mixBtn()
    {
        // 믹스버튼
        conditionCheck();
        if (mixItemIndex == 163)  /////////
        {
            inv.decreseItem(84);  /////////
            inv.decreseItem(87);  /////////
            inv.addItem(163);      /////////
            inv.ItemCheck();
        }
        StartCoroutine(CC());
    }

    public void conditionCheck()
    {
        if (mixSlot[1].number == -1 && mixSlot[2].number == 84 && mixSlot[3].number == -1 &&
            mixSlot[4].number == -1 && mixSlot[5].number == 87 && mixSlot[6].number == -1 &&
            mixSlot[7].number == -1 && mixSlot[8].number == -1 && mixSlot[9].number == -1) ///////////
        {
            mixItemIndex = 163; /////////
            checkMixItem();
        }


        else
        {
            IMG.sprite = nul;
            mixItemIndex = -1;
        }
    }

    public void checkMixItem()
    {
        IMG.sprite = inv.itemList[mixItemIndex].retSprite();
    }
    public void IMGNull()
    {
        IMG.sprite = nul;
    }

    IEnumerator CC()
    {
        yield return null;
        conditionCheck();
    }
}