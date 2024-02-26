using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotations : MonoBehaviour
{
    public float RotationSpeed = 20.0f;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
         transform.Rotate(
        Vector3.right * RotationSpeed *Time.deltaTime +
        Vector3.up  * RotationSpeed *Time.deltaTime +
        Vector3.forward  * RotationSpeed *Time.deltaTime,
        Space.Self
         );
    }
}
