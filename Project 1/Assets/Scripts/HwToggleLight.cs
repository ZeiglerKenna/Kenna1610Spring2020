using UnityEngine;

[RequireComponent(typeof(Light))]

public class HwToggleLight : MonoBehaviour
{
    private Light light;
    public float intensity = 1f;
    private float duration = 10f;
    public Color color1 = Color.white;
    public Color color2 = Color.red;

    private void Start()
    {
        light = GetComponent<Light>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            light.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            light.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            light.enabled = !light.enabled;
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            intensity = 2f;
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            intensity = 3f;
        }
        
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            intensity = 4f;
        }
        
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            intensity = 5f;
        }
        
        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            intensity = 6f;
        }
        
        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            intensity = 7f;
        }
        
        if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            intensity = 8f;
        }
        
        if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            intensity = 9f;
        }

        float time = Mathf.PingPong(Time.time, duration) / duration;
        light.color = Color.Lerp(color1, color2, time);
    }
    
    //Watched this video: https://www.youtube.com/watch?v=PCdg3cnQfZ4 and then played around with components to see what I could do
    //Followed tutorial on interpolating light colors and then adjusted script to get a feel for it: https://docs.unity3d.com/ScriptReference/Light-color.html
}
