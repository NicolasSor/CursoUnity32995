using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProperties : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDamage;
    public Vector3 bulletDirection;

    // Start is called before the first frame update
    void Start()
    {
        InicializarVectorDireccion();

    }

    private void Update()
    {
        MoveBullet(bulletSpeed);
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
}
