using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockColliderScript : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        // using this script to generate/active specific block 
        // depend on block's tag
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }

}
