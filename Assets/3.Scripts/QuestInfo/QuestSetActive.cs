using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSetActive : MonoBehaviour
{
    // 0. 미수락
    // 1. 수락
    // 2. 거절
    // 3. 완료
    void Update()
    {
        if(PlayerPrefs.GetInt(transform.name,0)!=1)
        {
            gameObject.SetActive(false);
        }
    }
}
