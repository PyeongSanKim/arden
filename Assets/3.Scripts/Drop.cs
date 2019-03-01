﻿using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public int number;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            Drag.dragingItem.transform.SetParent(this.transform);
            number = GetComponentInChildren<ItemInfo>().ItemID;
        }
    }

    void Update()
    {
        if (transform.childCount == 0)
        {
            number = -1;
        }
    }
}