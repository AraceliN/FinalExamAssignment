using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class VPlayerMovement : MonoBehaviour

{

    public Rigidbody2D Rb;

    public float playerSpeed = 4f;



    Vector2 movement;



    bool facingRight = true;



    void Update()

    {

        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");



        if (Mathf.Abs(movement.x) > Mathf.Abs(movement.y))

        {

            movement.y = 0;

        }

        else

        {

            movement.x = 0;

        }



        if (movement.x > 0 && !facingRight)

        {

            Flip();

        }



        if (movement.x < 0 && facingRight)

        {

            Flip();

        }

    }



    private void FixedUpdate()

    {

        Rb.MovePosition(Rb.position + movement * playerSpeed * Time.fixedDeltaTime);

    }



    void Flip()
    {

        Vector3 currentScale = gameObject.transform.localScale;

        currentScale.x *= -1;

        gameObject.transform.localScale = currentScale;



        facingRight = !facingRight;

    }

}
