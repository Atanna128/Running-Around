using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System;

public class PlayerScript : MonoBehaviour
{
    private ControllerScript controllerScript;
    public int score;
    bool isJumping;
    Rigidbody2D rb;
    private float lasttime;
    float curtime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        score = 0;
    }

    public void SetControllerScriptReference(ControllerScript script)
    {
        controllerScript = script;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;

        if (collision.gameObject.tag.Equals("JumpBlock")) {
            SpeedUp();
            Jump();            
        }else if (collision.gameObject.tag.Equals("DestroyBlock"))
        {
            Suicide();
        }
        //wait for new blocktype
        
    }

    private void Suicide()
    {
      
    }

    private void SpeedUp()
    {
        
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
