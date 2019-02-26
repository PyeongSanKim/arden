using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Transform itemTr;
    private Transform inventoryTr;

    private Transform itemListTr;
    private CanvasGroup canvasGroup;

    public static GameObject dragingItem = null;

    void Start()
    {
        inventoryTr = GameObject.Find("Pan_Item").transform;
        itemListTr = GameObject.Find("ItemContents").transform;
        itemTr = GetComponent<Transform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // 드래그 이벤트
    public void OnDrag(PointerEventData eventData)
    {
        itemTr.position = Input.mousePosition;
    }

    // 드래그 시작
    public void OnBeginDrag(PointerEventData eventData)
    {
        this.transform.SetParent(inventoryTr);
        dragingItem = this.gameObject;

        // 드래그가 시작되면 다른 UI 이벤트를 받지 않도록 설정
        canvasGroup.blocksRaycasts = false;
    }

    // 드래그 종료
    public void OnEndDrag(PointerEventData eventData)
    {
        // 드래그가 종료되면 드래그 아이템을 null
        dragingItem = null;
        // 드래그 종료시 UI이벤트를 다시 받음
        canvasGroup.blocksRaycasts = true;

        // 슬롯에 드래그 하지 않았을 때 원래대로 ItemList로 돌린다
        if (itemTr.parent == inventoryTr)
        {
            itemTr.SetParent(itemListTr.transform);
        }
    }
}