using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject player;
    public PlayerScript script;
    //private PlayerScript playerScript;
    //public void SetControllerScriptReference(PlayerScript script)
    //{
    //    playerScript = script;
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {            
            Destroy(gameObject);        
            // make music here
        }
    }
}
