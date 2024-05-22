using System.Collections;
using System.Collections.Generic;
//using TMPro;
using UnityEngine;
//using UnityEngine.Tilemaps;



public class VPlayerMovement : MonoBehaviour

{
    public Rigidbody2D Rb;
   // public Tilemap floorTilemap;
    public float playerSpeed = 4f;
    Vector2 movement;
    //public TextMeshProUGUI ActionPoints;
    public int actionPoints;

    public void Start()
    {
     //   actionPoints = 5;
      //  ActionPoints = GetComponent<TextMeshProUGUI>();
    }

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
    /*
    private void Move(Vector2 direction)
    {
        if (PlayerMove(direction))
        {
            actionPoints -= 1;
            ActionPoints.text = actionPoints.ToString();
        }
    }

    private bool PlayerMove(Vector2 direction)
    {
        Vector3Int gridPosition = floorTilemap.WorldToCell(transform.position + (Vector3)direction);
        if(direction.x > 0)
        {
            actionPoints -= 1;
            ActionPoints.text = actionPoints.ToString();
            return true;
        }
        else if(direction.y > 0)
        {
            actionPoints -= 1;
            ActionPoints.text = actionPoints.ToString();
            return true;
        }
        else
        {
            actionPoints = 0;
            ActionPoints.text = actionPoints.ToString();
            return false;
        }
    }*/

    private void FixedUpdate()
    {
        Rb.MovePosition(Rb.position + movement * playerSpeed * Time.fixedDeltaTime);
    }

}
