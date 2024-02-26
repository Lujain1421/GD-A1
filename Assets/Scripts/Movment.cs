using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

public class Movment : MonoBehaviour
{
    float speed= 10.0f;
    // Start is called before the first frame update
    void Start()
    {
          Vector3 vec2 =new Vector3(1, 2, 3); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += Vector3.right * speed *Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position += Vector3.left * speed *Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.position += Vector3.up * speed *Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.position += Vector3.down * speed *Time.deltaTime;
            }
    }
         
}
