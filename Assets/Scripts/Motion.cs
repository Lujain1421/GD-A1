using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0,0);
    }
}
