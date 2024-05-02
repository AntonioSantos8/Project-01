using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int moveSpeed;
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    rb = GetComponent<Rigidbody2D>();

 direction = Input.GetAxis("Horizontal");
 rb.velocity = new Vector2(direction* moveSpeed, rb.velocity.y);
}
}
