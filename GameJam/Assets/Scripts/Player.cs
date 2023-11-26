using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // components and gameobjects
    Rigidbody rb;
    GameObject playerRotation;

    // variables
    Vector3 velocity = Vector3.zero;
    Vector2 mouseRotation = Vector2.zero;


    public float speed = 5f;

    void Start()
    {
        playerRotation = GameManager.playerRotation;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        DirectionCheck();
    }

    void CheckMovement()
    {
        velocity = Vector3.zero + Vector3.up * rb.velocity.y;
        if (Input.GetKey(KeyCode.W)) velocity += transform.forward * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) velocity += -transform.forward * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) velocity += -transform.right * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) velocity += transform.right * speed * Time.deltaTime;
        rb.velocity = velocity;
    }

    // make the player rotate according to the mouse movement
    private void DirectionCheck()
    {
        // get the mouse rotation
        mouseRotation.y += Input.GetAxisRaw("Mouse X");
        mouseRotation.x += -Input.GetAxisRaw("Mouse Y");
        // clamp it
        mouseRotation.x = Mathf.Clamp(mouseRotation.x, -42f, 42f);
        
        // rotate the playerRotation object (for camera uses)
        playerRotation.transform.rotation = Quaternion.Euler(mouseRotation.x * 2, mouseRotation.y * 2, 0);

        // rotate the player object on y axis
        transform.rotation = Quaternion.Euler(0, mouseRotation.y * 2, 0);
    }
}
