using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    [SerializeField] private float speed;
    private Vector3 direction;



    // Update is called once per frame
    void Update()
    {
        SetDirection();
        Move();


    }
    private void Move()
    {
        transform.position += direction * (speed * Time.deltaTime);
    }
    private void SetDirection()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        direction.Set(horizontal, 0, vertical);
    }
}
