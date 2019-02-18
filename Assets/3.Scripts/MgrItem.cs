using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IndexInfo;

public class MgrItem : MonoBehaviour
{
    private DataMgr DM;
    public static ItemIndex II;
    //public GameObject[] ;
    void Awake()
    {
        DM = GetComponent<DataMgr>();
        DM.Initialize();
        II = DM.Load();
        while (II.Q.Count != 0)
        {
            Debug.Log(II.Q.Dequeue());
        }
    }

    public void SaveBtn()
    {
        DM.Save(II);
    }

    public void QuestAccept(int index)
    {
        II.Q.Enqueue(index);
    }
}
