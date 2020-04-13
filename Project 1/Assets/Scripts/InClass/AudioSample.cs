using System;
using UnityEngine;
using UnityEngine.Rendering;

public class AudioSample : MonoBehaviour
{
    public AudioClip sound;
    public GameObject ammo;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }

    void Shot()
    {
        Instantiate(ammo, transform.position, transform.rotation);
       // sound.Play;
    }
}
