using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerMovement : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float moveSpeed = 4f;
    private int movesLeft;
    public int maxMoves = 10;
    private Vector2 targetPosition;

    Vector2 movement;
    bool facingRight = true;

    private void Start()
    {
        movesLeft = maxMoves;
        targetPosition = transform.position;
    }

    void Update()
    {
        if (movesLeft > 0 && Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                targetPosition += Vector2.up;
                movesLeft--;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                targetPosition += Vector2.down;
                movesLeft--;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                targetPosition += Vector2.left;
                movesLeft--;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                targetPosition += Vector2.right;
                movesLeft--;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), "Moves Left: " + movesLeft);
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;
        facingRight = !facingRight;
    }
}
