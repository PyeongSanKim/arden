using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public int number;
    public MixMgr MM;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            Drag.dragingItem.transform.SetParent(this.transform);
            number = GetComponentInChildren<ItemInfo>().ItemID;
            MM.conditionCheck();
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