using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPropertiesClase6 : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDamage;
    public float timeToDestroy;
    private float timeLeftToDestroy;
    public Vector3 bulletDirection;

    // Start is called before the first frame update
    void Start()
    {
        InicializarVectorDireccion();
        ResetTimer();
    }

 

    private void Update()
    {
        MoveBullet(bulletSpeed);
        CountdownToDestroy();
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ScaleUp();
        }
    }

    private void ScaleUp()
    {
        this.transform.localScale = this.transform.localScale * 2;
    }

    private void CountdownToDestroy()
    {
        timeLeftToDestroy -= Time.deltaTime;
        if (timeLeftToDestroy <= 0)
        {
            Destroy(this.gameObject);
            ResetTimer();
        }
    }

    private Vector3 MoveBullet(float bulletSpeed)
    {
        return transform.position += (bulletDirection * bulletSpeed * Time.deltaTime);
    }

    //Limito las componentes del vector entre -1 a 1 para que el vector resultante pueda tomar cualquier direccion.
    private void InicializarVectorDireccion()
    {
        if (bulletDirection.x > 1)
            bulletDirection.x = 1;
        if (bulletDirection.x < -1)
            bulletDirection.x = -1;
        if (bulletDirection.y > 1)
            bulletDirection.y = 1;
        if (bulletDirection.y < -1)
            bulletDirection.y = -1;
        if (bulletDirection.z > 1)
            bulletDirection.z = 1;
        if (bulletDirection.z < -1)
            bulletDirection.z = -1;
    }
    private void ResetTimer()
    {
        timeLeftToDestroy = timeToDestroy;
    }
}
