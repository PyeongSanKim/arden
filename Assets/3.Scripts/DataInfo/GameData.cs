using System.Collections.Generic;
using UnityEngine;

namespace DataInfo
{
    [System.Serializable]
    public class GameData
    {
        public int Level = 1;
        public int EXP = 0;
        // 퀘스트
        public List<int> equipItem = new List<int>();
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
