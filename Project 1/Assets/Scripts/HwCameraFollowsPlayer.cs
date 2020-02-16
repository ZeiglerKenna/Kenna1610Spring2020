using UnityEngine;

public class HwCameraFollowsPlayer : MonoBehaviour
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
    
    //Tutorial: https://learn.unity.com/tutorial/movement-basics?projectId=5c514956edbc2a002069467c#5c7f8528edbc2a002053b711

    private void Update()
     {
         var vector3 = new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X") * speed);
         transform.Rotate(vector3 * (speed * Time.deltaTime));
     }
 }
