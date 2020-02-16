using System;
using UnityEngine;

[RequireComponent(typeof(LensFlare))]

public class HwLensFlareComponentScript : MonoBehaviour
{
 private LensFlare lensFlare;
 public float brightness = 10f;
 public float fadeSpeed = 5f;

 private void Start()
 {
  lensFlare = GetComponent<LensFlare>();
 }

 private void OnEnable()
 {
  brightness.Equals(20f);
  fadeSpeed.Equals(10f);
 }

 private void OnDisable()
 {
  brightness.Equals(10f);
  fadeSpeed.Equals(1f);
 }
}
