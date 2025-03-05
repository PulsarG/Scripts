using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Main Hero
public class Player : MonoBehaviour
{

    public static Player Instance { get; private set; }
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;

    private bool isRunningToRight = false;
    private bool isRunningToLeft = false;
    private bool isRunningToUp = false;
    private bool isRunningToDown = false;

    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        Vector2 inputVector = new Vector2(0, 0);

        MoveFromKey(inputVector);

    }

    private void MoveFromKey(Vector2 inputVector)
    {
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = 1f;
        }

        inputVector = inputVector.normalized;

        rb.MovePosition(rb.position + inputVector * (moveSpeed * Time.fixedDeltaTime));

        SwitchAnimation(inputVector);
    }

    private void SwitchAnimation(Vector2 inputVector)
    {
        if (inputVector.x > 0f)
        {
            isRunningToRight = true;

            isRunningToLeft = false;
            isRunningToUp = false;
            isRunningToDown = false;
        }
        else if (inputVector.x < 0f)
        {
            isRunningToLeft = true;

            isRunningToRight = false;
            isRunningToUp = false;
            isRunningToDown = false;
        }
        else if (inputVector.y > 0f)
        {
            isRunningToUp = true;

            isRunningToRight = false;
            isRunningToLeft = false;
            isRunningToDown = false;
        }
        else if (inputVector.y < 0f)
        {
            isRunningToDown = true;

            isRunningToRight = false;
            isRunningToLeft = false;
            isRunningToUp = false;
        }
        else
        {
            isRunningToRight = false;
            isRunningToLeft = false;
            isRunningToUp = false;
            isRunningToDown = false;
        }
    }

    public bool IsRunningToR()
    {
        return isRunningToRight;
    }

    public bool IsRunningToL()
    {
        return isRunningToLeft;
    }

    public bool IsRunningToU()
    {
        return isRunningToUp;
    }

    public bool IsRunningToD()
    {
        return isRunningToDown;
    }
}
