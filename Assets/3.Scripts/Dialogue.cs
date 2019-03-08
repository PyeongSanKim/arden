using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    // 다음 대화가 없을 경우 0 있을경우엔 고유 인덱스 작성
    public int DialougeIndex;
    public string name;
    public Sprite sprite;
    public Sprite Itemsprite;

    [TextArea(3, 10)]
    public string[] sentences;
}