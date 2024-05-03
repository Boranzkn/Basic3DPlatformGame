using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float pushForce = 520f, speed = 600f, movement;
    [HideInInspector] public Vector3 spawnPoint = new Vector3 (0, 1, -124);

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            gameManager.RespawnPlayer();
        }
    }
}
