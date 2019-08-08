using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockColliderScript : MonoBehaviour
{
    public float velocity = 10;
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<BoxCollider2D>().attachedRigidbody.velocity = new Vector2(-1,0);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision.rigidbody.velocity = new Vector2(0, 0);
        Vector2 a = collision.otherRigidbody.worldCenterOfMass;
        //Debug.Log(a);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        //collision.rigidbody.velocity = new Vector2(0,0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("On trigger Enter");
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
