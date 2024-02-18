using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] public float lifetime;
    [SerializeField] public float speed;


    // Start is called before the first frame update
    void Awake()
    {
       Destroy(gameObject, lifetime); 
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(speed* Time.deltaTime, 0, 0);
    }
}
