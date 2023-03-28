using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public FixedJoystick FixedJoystickOnCanvas;
    public Rigidbody2D RigidBodyOfPlayer;
    readonly float MovementSpeed = 10;
    float vertical, horizontal;

    private void Start()
    {
        RigidBodyOfPlayer = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        horizontal = FixedJoystickOnCanvas.Horizontal * MovementSpeed * Time.deltaTime;
        transform.Translate(horizontal, 0, 0);
    }
}
