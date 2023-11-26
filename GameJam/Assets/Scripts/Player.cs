using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // components and gameobjects
    Rigidbody rb;

    // variables
    Vector3 velocity = Vector3.zero;

    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
    }

    void CheckMovement() {
        velocity = Vector3.zero + Vector3.up * rb.velocity.y;
        if (Input.GetKey(KeyCode.W)) velocity += transform.forward * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) velocity += -transform.forward * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) velocity += -transform.right * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) velocity += transform.right * speed * Time.deltaTime;
        rb.velocity = velocity;
    }
}
