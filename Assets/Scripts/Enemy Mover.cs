using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * 1f * Time.deltaTime;

    }
}
