using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float xDir;
    private float yDir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.LeftArrow)){
        //     Vector2 position = this.transform.position;
        //     position.x--;
        //     this.transform.position = position;
        // }
        xDir = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xDir * 7f, rb.velocity.y);
        yDir = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, yDir * 7f);
    }
}
