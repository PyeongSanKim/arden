using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public int number;
    void Awake()
    {

    }

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            Drag.dragingItem.transform.SetParent(this.transform);
            number = GetComponentInChildren<InventorySlot>().itemID;
        }
    }

    void Update()
    {
        if (transform.childCount == 0)
        {
            number = 0;
        }
    }
}