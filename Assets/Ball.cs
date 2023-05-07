using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int forceFactor = 300;
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void PushLeft()
    {
        rigidBody.AddForce(Vector2.left * forceFactor);
    }
    public void PushRight()
    {
        rigidBody.AddForce(Vector2.right * forceFactor);
    }
    public void PushUp()
    {
        rigidBody.AddForce(Vector2.up * forceFactor);
    }
    public void PushDown()
    {
        rigidBody.AddForce(Vector2.down * forceFactor);
    }
}

