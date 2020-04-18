using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class HealthImageBehavior : MonoBehaviour
{
    private Image imageObj;
    public FloatData dataObj;
    public float t;

    private void Start()
    {
        imageObj = GetComponent<Image>();

    }

    private void Update()
    {
        imageObj.fillAmount = dataObj.value;
        
        if (imageObj.fillAmount <= 0.5)
        {
            imageObj.color = Color.Lerp(Color.green, Color.yellow, t);
            t = t + 0.1f;
        }

        if (imageObj.fillAmount <= 0.2)
        {
            imageObj.color = Color.Lerp(Color.yellow, Color.red, t);
            t = t + 0.1f;
        }
        
        if (imageObj.fillAmount >= 0.5)
        {
            imageObj.color = Color.Lerp(Color.yellow, Color.green, t);
            t = t + 0.1f;
        }

        if (imageObj.fillAmount <= 0)
        {
            
        }
    }
}
