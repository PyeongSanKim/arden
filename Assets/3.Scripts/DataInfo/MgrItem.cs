using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DataInfo;
public class MgrItem : MonoBehaviour
{
    private DataManager DM;
    public GameData gameData;

    public static int A = 50;

    private void Awake()
    {
        DM = GetComponent<DataManager>();
        DM.Initialize();
        LoadBtn();
    }

    public void SaveBtn()
    {
        DM.Save(gameData);
    }

    public void LoadBtn()
    {
        GameData data = DM.Load();

        gameData.Level = data.Level;
        gameData.EXP = data.EXP;
        gameData.equipItem = data.equipItem;
    }
    void OnDisable()
    {
        SaveBtn();
    }
}
