using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}
