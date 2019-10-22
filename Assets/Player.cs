using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public Vector2 velocity;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        velocity = input.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
    }
}
