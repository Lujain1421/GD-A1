using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject bulletprefab;
    public float bulletspeed =10f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletprefab, BulletSpawnPoint.position, new Quaternion());
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * bulletspeed;
        }
    }
    }

