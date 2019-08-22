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
    public int coin;
    bool isJumping;
    Rigidbody2D rb;
    private float lasttime;
    float curtime;
    public GameObject playGround;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        score = 0;
        LoadPlayer();
        
    }

    private void LateUpdate()
    {
        SavePlayer();
    }

    public void SetControllerScriptReference(ControllerScript script)
    {
        controllerScript = script;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(isJumping == true)
        {
            playGround.GetComponent<ControllerScript>().turnDirection = 0.8f;
            isJumping = false;
        }
        if (collision.gameObject.tag.Equals("Coin"))
        {
            coin += 10;
            //Debug.Log("get coin:" + coin);
        }
        else if (collision.gameObject.tag.Equals("JumpBlock")) {
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
        playGround.GetComponent<ControllerScript>().turnDirection = 2.0f;
        
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

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        coin = data.coin;
    }
}
