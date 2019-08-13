using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockColliderScript : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision.rigidbody.velocity = new Vector2(0, 0);
        Vector2 a = collision.otherRigidbody.worldCenterOfMass;
        //Debug.Log(a);
    }

}
