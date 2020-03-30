using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(Text))]
public class TextBehavior : MonoBehaviour
{
    private Text textObj;
    
    void Start()
    {
        textObj = GetComponent<Text>();
    }

    public void ChangeText(string message)
    {
        textObj.text = message;
    }

    public void ChangeText(IntData obj)
    {
        textObj.text = obj.value.ToString();
    }
}