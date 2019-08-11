using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BorderColliderScript : MonoBehaviour
{
    public GameObject border;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //border.GetComponent<Image>().color = Color.red;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //border.GetComponent<Image>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
