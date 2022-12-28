using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float inputx;
    float inputy;
    [SerializeField] float movementSpeed;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        inputx = Input.GetAxisRaw("Horizontal");
        inputy = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(inputx * movementSpeed, inputy * movementSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Lens")
            collision.GetComponent<PickUp>().ChangeColour();
    }
}
