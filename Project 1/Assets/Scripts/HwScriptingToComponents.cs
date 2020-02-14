using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class HwScriptingToComponents : MonoBehaviour
{

    public SpriteRenderer spriteRender;

    void Start()
    {
        spriteRender.color = Color.red;
    }
    
    private void OnEnable()
    {
        spriteRender.color = Color.red;
    }

    private void OnDisable()
    {
        spriteRender.color = Color.red;
    }
}
