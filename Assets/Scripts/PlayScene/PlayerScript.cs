using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class PlayerScript : MonoBehaviour
{
    private ControllerScript controllerScript;
    float speed= 10;
    float jumpForce = 200f;
    bool isJumping;
    Rigidbody2D rb;
    private float lasttime;
    float curtime;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    public void SetControllerScriptReference(ControllerScript script)
    {
        controllerScript = script;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
        // will be modified whenever hit the side of another block instead of top and btm of block
        controllerScript.changeDirection();
    }

    private IEnumerator Coroutine()
    {
        isJumping = true;
        GetComponent<Rigidbody2D>().gravityScale *= -1;
        yield return new WaitForSeconds(0.3f);        
        GetComponent<Rigidbody2D>().gravityScale *= -1;        

    }
    public void Jump()
    {
        if (!isJumping) {            
            StartCoroutine(Coroutine());
        }
    }
}
