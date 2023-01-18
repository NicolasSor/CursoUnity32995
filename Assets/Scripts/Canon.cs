using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject cannonBall;
    public Transform instantiatePosition;
    public float timeBetweenShots;
    [SerializeField] private KeyCode shootKeyCode;

    private void Update()
    {
        if (Input.GetKeyDown(shootKeyCode))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.J)) 
        {
            Invoke("Shoot", 1.0f);
            Invoke("Shoot", 2.0f);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Invoke("Shoot", 1.0f);
            Invoke("Shoot", 2.0f);
            Invoke("Shoot", 3.0f);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Invoke("Shoot", 1.0f);
            Invoke("Shoot", 2.0f);
            Invoke("Shoot", 3.0f);
            Invoke("Shoot", 4.0f);
        }
    }

     private void Shoot()
    {
        Instantiate(cannonBall, instantiatePosition);      
    }


}
