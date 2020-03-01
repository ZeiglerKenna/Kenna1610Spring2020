using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HwCameraFollowsPlayerOnlyNoMouse : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset;
    public float speed = 80f;

    private void Start()
    {
        cameraOffset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
