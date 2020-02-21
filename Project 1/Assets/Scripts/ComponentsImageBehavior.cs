using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class ComponentsImageBehavior : MonoBehaviour
{
    private Image imageObj;
    public int currentHealth;

    private void Start()
    {
        imageObj = GetComponent<Image>();
    }

    private void Update()
    {
        imageObj.fillAmount = currentHealth;
    }
}
