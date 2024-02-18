using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]public GameObject shpere;

    void Update()

    // Start is called before the first frame update
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        SpawnShpere();
        InvokeRepeating("SpawnShpere", 0.0f, 1.0f);
      }

      if (Input.GetKeyUp(KeyCode.Space))
      {
        CancelInvoke();
      }

    }

    // Update is called once per frame
    void SpawnShpere()
    {
        Instantiate(shpere,transform.position,Quaternion.identity);
    }
    
}
