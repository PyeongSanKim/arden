﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveFalse : MonoBehaviour
{
    private void Update()
    {
        if(PlayerPrefs.GetInt("tuto").Equals(1))
        {
            Btn();
        }
    }

    public void Btn()
    {
        gameObject.SetActive(false);
    }
}
