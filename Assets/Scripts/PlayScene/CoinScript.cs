using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject player;
    
    private PlayerScript playerScript;
    public void SetControllerScriptReference(PlayerScript script)
    {
        playerScript = script;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            //playerScript.score += 10;
            player.GetComponent<PlayerScript>().score += 10;
            Debug.Log(player.GetComponent<PlayerScript>().score);
            Destroy(gameObject);
        
        }
    }
}
