using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb2d;
    private Vector2 movement;
    private Vector2 pos;
    Animator anim;
    bool faceRight = true;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (moveHorizontal != 0)
        {
            pos = transform.position;
            movement = new Vector2(moveHorizontal, 0);
            transform.Translate(movement * speed);
            if (moveHorizontal > 0)
            {
                faceRight = true;
                anim.Play("walkFWDAni");
            }
            else if (moveHorizontal < 0)
            {
                faceRight = false;
                anim.Play("walkBWDAni");
            }
        }
        else
        {
            if (faceRight)
            {
                anim.Play("idleRightAni");
            }
            else
            {
                anim.Play("idleLeftAni");
            }
        }
    }
}
