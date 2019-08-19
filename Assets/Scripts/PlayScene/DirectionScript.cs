using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionScript : MonoBehaviour
{

    private ControllerScript controllerScript;
    public void SetControllerScriptReference(ControllerScript script)
    {
        controllerScript = script;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.tag.Equals("Coin")) {  
            controllerScript.changeDirection();
        }
    }
}
