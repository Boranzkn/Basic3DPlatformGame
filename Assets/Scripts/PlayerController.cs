using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float pushForce = 500f, speed = 600f, movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, pushForce * Time.fixedDeltaTime);

        rb.velocity = new Vector3(movement * speed *  Time.fixedDeltaTime, rb.velocity.y, rb.velocity.z);
    }
}
