using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_huisjebouw : MonoBehaviour
{

    public float speed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    private void Start()
    {
        GameManager.instance.StartGame(7f,false,"place the roof");
    }

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Animations
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
