using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Rigidbody2D rb;
    Animator playerAnimator;
    public float move_speed = 2.0f;
    public float jump_speed, jump_frequency, next_jump_time;
    bool face_right = true;
    public bool is_grounded = false;

    public Transform on_ground_target;
    public float on_ground_radius;
    public LayerMask on_ground_mask;


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
        OnGroundCheck();

        if (rb.velocity.x > 0 && face_right == false)
        {
            faceTurn();
        }
        if (rb.velocity.x < 0 && face_right == true)
        {
            faceTurn();
        }

        if (Input.GetAxis("Vertical") > 0 && is_grounded && next_jump_time < Time.timeSinceLevelLoad)
        {
            next_jump_time = Time.timeSinceLevelLoad + jump_frequency;
            Jump();
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

    void Jump()
    {
        rb.AddForce(new Vector2(0f, jump_speed));
    }

    void OnGroundCheck()
    {
        is_grounded = Physics2D.OverlapCircle(on_ground_target.position, on_ground_radius, on_ground_mask);
        playerAnimator.SetBool("isGroundAnim", is_grounded);
    }
}
