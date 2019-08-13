using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private ControllerScript controllerScript;
    public float speed;
    public float jumpForce;
    bool isJumping;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetControllerScriptReference(ControllerScript script)
    {
        controllerScript = script;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        controllerScript.changeDirection();
    }

    public void Jump()
    {
        Debug.Log("jumping");
    }
}
