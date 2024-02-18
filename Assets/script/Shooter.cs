using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            shoot();
            InvokeRepeating("Shoot", 0.0f,0.5f);
        }
       if (Input.GetKeyUp(KeyCode.A))
        {
            CancelInvoke();
        }
    
    }
    void shoot()
    {
        Instantiate(Sphere, transform.position,Quaternion.identity);
    }
}
