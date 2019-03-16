using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Quest : MonoBehaviour
{
    public GameObject[] NPC;

    void Start()
    {
        NPCCheck();
    }

    public void NPCCheck()
    {
        if (PlayerPrefs.GetInt("Quest1").Equals(-1))
        {
            NPC[8].SetActive(true);
        }
        if (PlayerPrefs.GetInt("Quest2").Equals(-1))
        {
            NPC[3].SetActive(true);
        }
        if (PlayerPrefs.GetInt("Quest3").Equals(-1))
        {
            NPC[4].SetActive(true);
        }
        if (PlayerPrefs.GetInt("Quest4").Equals(-1))
        {
            NPC[0].SetActive(true);
        }
    }
}
