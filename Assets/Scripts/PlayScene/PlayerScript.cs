using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
            Jump(0.3f);
            SpeedDown();
        }else if (collision.gameObject.tag.Equals("DestroyBlock"))
        {
            Retry();
        }else if (collision.gameObject.tag.Equals("Border"))
        {
            Retry();
        }
        //wait for new blocktype
        
    }

    private void Retry()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }


    private void SpeedUp()
    {
        
    }

    private void SpeedDown()
    {

    }
    private IEnumerator Coroutine(float timer)
    {
        isJumping = true;
        GetComponent<Rigidbody2D>().gravityScale *= -1;
        yield return new WaitForSeconds(timer);        
        GetComponent<Rigidbody2D>().gravityScale *= -1;
        

    }
    public void Jump(float timer)
    {
        if (!isJumping) {            
            StartCoroutine(Coroutine(timer));
        }
    }

}
