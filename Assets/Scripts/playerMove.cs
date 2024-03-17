using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Rigidbody2D rb;
    Animator playerAnimator;
    public float move_speed = 2.0f;
    bool face_right = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKey(KeyCode.Space))
        {
            print("Space tuþuna basýldý");
        }*/
        HorizontalMove();
        
        if(rb.velocity.x > 0 && face_right == false)
        {
            faceTurn();
        }
        if (rb.velocity.x < 0 && face_right == true)
        {
            faceTurn();
        }

    }
    void HorizontalMove()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * move_speed, rb.velocity.y);
        playerAnimator.SetFloat("paramRun", Mathf.Abs(rb.velocity.x));

    }

    void faceTurn()
    {
        face_right = !face_right;
        Vector3 temp_local_scale = transform.localScale;
        temp_local_scale.x *= -1;
        transform.localScale = temp_local_scale;
    }
}
