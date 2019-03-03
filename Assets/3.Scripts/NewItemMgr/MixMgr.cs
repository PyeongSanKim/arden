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
        if (mixItemIndex == 2)
        {
            inv.decreseItem(0);
            inv.decreseItem(1);
            inv.addItem(2);
            inv.ItemCheck();
        }
        StartCoroutine(CC());
    }

    public void conditionCheck()
    {
        if (mixSlot[1].number == -1 && mixSlot[2].number == 0 && mixSlot[3].number == -1 &&
            mixSlot[4].number == -1 && mixSlot[5].number == 1 && mixSlot[6].number == -1 &&
            mixSlot[7].number == -1 && mixSlot[8].number == -1 && mixSlot[9].number == -1)
        {
            mixItemIndex = 2;
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