using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClickColorData
{
    [SerializeField]
    private string objectType;
    [SerializeField]
    private int
        minClicksCount,
        maxClicksCount;
    [SerializeField]
    private Color color;

    public string ObjectType { get { return objectType; } }
    public int MinClicksCount { get { return minClicksCount; } }
    public int MaxClicksCount { get { return maxClicksCount; } }
    public Color Color { get { return color; } }
}
