using System.Collections.Generic;

namespace IndexInfo
{
    //[System.Serializable]
    //public class QuestIndex
    //{
    //    public Queue<int> Q = new Queue<int>();
    //}

    [System.Serializable]
    public class ItemIndex
    {
        public Queue<Item> Q = new Queue<Item>();
    }
}