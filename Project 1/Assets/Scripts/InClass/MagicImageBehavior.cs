using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class MagicImageBehavior : MonoBehaviour
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
            imageObj.color = Color.Lerp(Color.cyan, Color.blue, t);
            t = t + 0.1f;
        }

        if (imageObj.fillAmount <= 0.2)
        {
            imageObj.color = Color.Lerp(Color.blue, Color.black, t);
            t = t + 0.1f;
        }
        
        if (imageObj.fillAmount >= 0.5)
        {
            imageObj.color = Color.Lerp(Color.blue, Color.cyan, t);
            t = t + 0.1f;
        }

        if (imageObj.fillAmount <= 0)
        {
            
        }
    }
}