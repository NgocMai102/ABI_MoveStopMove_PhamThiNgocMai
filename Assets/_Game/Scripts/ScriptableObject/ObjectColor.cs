using System.Collections;
using System.Collections.Generic;
using _Framework.Pool.Scripts;
using UnityEngine;

public enum ColorType
{
    None = 0,
    Red = 1,
    Green = 2,
    Blue = 3,
    Yellow = 4,
    Purple = 5,
    Orange = 6,
    Cyan = 7,
    White = 8,
    Black = 9,
}

public class ObjectColor : GameUnit
{
    [SerializeField] private ColorData colorData;
    [SerializeField] private Renderer meshRenderer;
    public ColorType color;

    public void Awake()
    {
        OnInit();
        
    }

    public void OnInit()
    {
        ChangeColor(color);
    }

    public void ChangeColor(ColorType colorType)
    {
        color = colorType;
        meshRenderer.material = colorData.GetMat(colorType);
    }
}
