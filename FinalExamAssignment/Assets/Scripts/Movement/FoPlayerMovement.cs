
using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class FoPlayerMovement : MonoBehaviour

{

    public Rigidbody2D Rb;

    public float playerSpeed = 4f;

    public GameObject PirateCoveBlue;

    Vector2 movement;




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

    }



    private void FixedUpdate()

    {

        Rb.MovePosition(Rb.position + movement * playerSpeed * Time.fixedDeltaTime);

    }

    public void ResetFoxy()
    {
        transform.position = PirateCoveBlue.transform.position;
    }
}
