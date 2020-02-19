using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class ComponentsImageBehavior : MonoBehaviour
{
    private Image imageObj;

    private void Start()
    {
        imageObj = GetComponent<Image>();
    }
    
    
}
