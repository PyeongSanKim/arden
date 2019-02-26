using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invetory : MonoBehaviour
{
    public static Invetory instance;

    private DatabaseMgr theDatabase;
    private InventorySlot[] slots; // 인벤토리 슬롯
    private List<Item> invetoryItemList; // 플레이어가 소지한 아이템

    public Transform ItemContents; // 슬롯의 부모

    void Start()
    {
        instance = this;
        theDatabase = FindObjectOfType<DatabaseMgr>();
        invetoryItemList = new List<Item>();
        slots = ItemContents.GetComponentsInChildren<InventorySlot>();
        invetoryItemList.Add(new Item(1021, "빈 병", "빔", Item.ItemType.Use));

        for (int i = 0; i <16; i++)
        {
            slots[i].gameObject.SetActive(false);
        }
    }

    public void ShowItem()
    {
        for(int i=0;i<invetoryItemList.Count;i++)
        {
            slots[i].gameObject.SetActive(true);
            slots[i].Additem(invetoryItemList[i]);
        }
    }

    public void GetAnItem(int _itemID, int _count = 1)
    {
        for(int i = 0;i<theDatabase.itemList.Count;i++) // 데이터베이스 아이템 검색
        {
            if(_itemID == theDatabase.itemList[i].itemID) // 데이터베이스 아이템 발견
            {
                for(int j=0;j<invetoryItemList.Count;j++) // 소지품에 같은 아이템이 있는지 확인
                {
                    if(invetoryItemList[j].itemID == _itemID) // 소지품에 같은 아이템이 있다 => 개수증가
                    {
                        invetoryItemList[j].itemCount += _count;
                        return;
                    }
                }
                invetoryItemList.Add(theDatabase.itemList[i]); // 없다 => 소지품에 해당 아이템 추가
                return;
            }
        }
        Debug.LogError("데이터베이스에 해당 ID값을 가진 아이템이 존재하지 않습니다.");
    }

    void Update()
    {
        ShowItem();
    }
}
