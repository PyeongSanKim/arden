using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MgrCollection : MonoBehaviour
{
    public GameObject[] CollectionMap;
    MgrLobby ML;

    void Awake()
    {
        ML = GetComponent<MgrLobby>();
    }

    public void CollectionMapBtn(int index)
    {
        ML.AllBtnDown();
        for(int i=0;i<CollectionMap.Length;i++)
        {
            CollectionMap[i].SetActive(false);
        }
        CollectionMap[index].SetActive(true);
    }
}
