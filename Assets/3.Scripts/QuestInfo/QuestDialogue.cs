using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestDialogue
{
    public Sprite[] sprites;

    [TextArea(3, 10)]
    public string[] sentences;
}