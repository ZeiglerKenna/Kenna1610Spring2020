using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class ComponentsImageBehavior : MonoBehaviour
{
    private Image imageObj;
    public float currentHealth;
    public float t;

    private void Start()
    {
        imageObj = GetComponent<Image>();

        if (imageObj.fillAmount <= 0.5)
        {
            imageObj.color = Color.Lerp(Color.green, Color.yellow, t);
            t = t + 0.1f;
        }

        if (imageObj.fillAmount <= 0.02)
        {
            imageObj.color = Color.Lerp(Color.yellow, Color.red, t);
            t = t + 0.1f;
        }
    }

    private void Update()
    {
        imageObj.fillAmount = currentHealth;
    }
}
