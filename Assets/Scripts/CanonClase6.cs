using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonClase6 : MonoBehaviour
{
    public float timeToInstantiate;   
    private float timeLeftToInstantiate;
    public Transform instantiatePostition;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }



    // Update is called once per frame
    void Update()
    {
        CountdownToInstantiate();
    }

    private void CountdownToInstantiate()
    {
        timeLeftToInstantiate -= timeToInstantiate * Time.deltaTime;
        if (timeLeftToInstantiate <= 0)
        {
            InstantiateBullet();
            ResetTimer();
        }
    }

    private void InstantiateBullet()
    {
        Instantiate(bullet, instantiatePostition);
    }

    private void ResetTimer()
    {
        timeLeftToInstantiate = timeToInstantiate;
    }
}
