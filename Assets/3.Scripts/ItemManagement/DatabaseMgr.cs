using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseMgr : MonoBehaviour
{
    static public DatabaseMgr instance;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }

    public string[] var_name;
    public float[] var;

    public string[] switch_name;
    public bool[] switches;

    public List<Item> itemList = new List<Item>();

    // 아이템 리스트 (DB임)
    void Start()
    {
        itemList.Add(new Item(1002, "파란 포션", "마나를 15채워줌", Item.ItemType.Use));
        itemList.Add(new Item(1003, "농축 빨간 포션", "체력을 350 채워줌", Item.ItemType.Use));
        itemList.Add(new Item(1004, "농축 파란 포션", "마나를 80 채워줌", Item.ItemType.Use));
        itemList.Add(new Item(1005, "단검", "기본적인 용사의검", Item.ItemType.Equip));
        itemList.Add(new Item(1006, "고대유물", "고대의 유물", Item.ItemType.Quest));
        itemList.Add(new Item(1021, "빈 병", "비어있는 병", Item.ItemType.Quest));
        itemList.Add(new Item(1022, "빨간 포션", "체력을 50 채워줌", Item.ItemType.Use));
        itemList.Add(new Item(1023, "붉은 꽃", "붉은 꽃 이뿌당 히읗", Item.ItemType.Quest));


    }
}
