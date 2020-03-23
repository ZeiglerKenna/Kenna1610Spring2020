using System;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]

public class HwComponentUI : MonoBehaviour
{

    public Dropdown uiDropDown;
    public int optionCount;

    private void Start()
    {
        print("Choose one!");
    }
}
