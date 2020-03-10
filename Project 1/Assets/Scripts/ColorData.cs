using UnityEngine;

[CreateAssetMenu]

public class ColorData : ScriptableObject
{

    public Color color;

    public Color Color
    {
        get => color;
        set => color = value;
    }
}
