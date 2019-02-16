using System.Collections.Generic;
using UnityEngine;
namespace DataInfo
{
    [System.Serializable]
    public class Item
    {
        public int Index;
        public string name;
        public string desc;
        public float price;
    }

    [System.Serializable]
    public class Quest
    {
        public int Index;
        public string name;
        public string human;

        [TextArea(3, 10)]
        public string desc;

        public int result;
    }
}