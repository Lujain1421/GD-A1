using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Transform playertransform;
    Vector3 cameraRotation;
    float initialCameraOffset;
    float mouseSensitivity = 2.0f;
    void Start()
    {
       playertransform = GameObject.FindGameObjectsWithTag("player").transform
       ;
       initialCameraOffset = Vector3.Distance(transform.position, playertransform.position);
       cameraRotation = transform.rotation.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {
        if (playertransform)
        {
            float mouseX = Input.GetAxis("Mouse X");

            If (mouseX != 0)
            {
               cameraRotation.y += mouseX * mouseSensitivity;
            }

            transform.eulerAngles = cameraRotation;

            Vector3 cameraLookDirection = Quaternion.Euler(cameraRotation) * Vector3.forward;
            
            transform.position = -cameraLookDirection * initialCameraOffset + playertransform.position;

            Vector3 playerRotation = playertransform.eulerAngles;
            playerRotation.y = transform.rotation.eulerAngles.y;
            playertransform.eulerAngles = playerRotation;

        }
    }
}
