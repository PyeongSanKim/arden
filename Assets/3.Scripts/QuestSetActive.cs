using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSetActive : MonoBehaviour
{
    void Update()
    {
        if(PlayerPrefs.GetInt(transform.name,0).Equals(0))
        {
            gameObject.SetActive(false);
        }
    }
}
