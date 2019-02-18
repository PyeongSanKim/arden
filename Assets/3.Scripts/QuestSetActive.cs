using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSetActive : MonoBehaviour
{
    void Awake()
    {
        if(PlayerPrefs.GetInt(transform.name,0).Equals(0))
        {
            gameObject.SetActive(false);
            Debug.Log(transform.name + "퀘스트는 아직이다.");
        }
    }
}
