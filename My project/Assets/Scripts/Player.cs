using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(horizontal * 5, rb.velocity.y);

    }
}