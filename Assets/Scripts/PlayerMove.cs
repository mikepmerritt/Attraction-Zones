using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public FloatVariable playerSpeed;

    Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>(); // get attached rigidbody
    }

    private void FixedUpdate() {
        // set player's velocity to move in the held direction times their speed
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * playerSpeed.value;
    }
}
