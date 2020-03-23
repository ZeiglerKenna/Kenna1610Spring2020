using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TrailRenderer))]

public class HwTrailComponent : MonoBehaviour
{
    private TrailRenderer trailRenderer;
    public Gradient colorChange;

    private void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        trailRenderer.material = new Material(Shader.Find("Sprites/Default"));

        float alpha = 1.0f;
        colorChange = new Gradient();
        colorChange.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Color.white, 0.0f), new GradientColorKey(Color.yellow, 2.0f) },
        new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 2.0f) });
        trailRenderer.colorGradient = colorChange;
    }

    private void Update()
    {
       trailRenderer.transform.position =
           new Vector3(Mathf.Sin(Time.time * 1.0f) * 8.0f, Mathf.Cos(Time.time * 4.0f) * 4.0f, 0.0f); 
    }
    
    //Code Source: https://docs.unity3d.com/ScriptReference/TrailRenderer-colorGradient.html
}
