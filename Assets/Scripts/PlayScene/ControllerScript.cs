using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ControllerScript : MonoBehaviour
{
    public GameObject block;
    public GameObject playGround;
    private float lasttime;
    private List<GameObject> AnnularList1 = new List<GameObject>();
    public GameObject Circle1;

    public GameObject Ann1;
    public GameObject Ann2;
    public GameObject Ann3;
    public GameObject Ann4;
    public GameObject Ann5;
    public GameObject Ann6;
    public GameObject Ann7;
    public GameObject Ann8;

    public List<GameObject> blockList = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        lasttime = Time.time;
        Circle1.GetComponentInChildren<Image>().transform.Rotate(0.5f,0,0); 
    }

    // Update is called once per frame
   
    void Update()
    {
        
        float time = Time.time;
        //if((time-lasttime) >0.5)
        //{

        ////}
        playGround.transform.Rotate(new Vector3(00, 0, 0.8f));
        //pic2.transform.Rotate(new Vector3(00, 0, -0.3f));

        //foreach (GameObject planet in blockList)
        //{
        //    Vector2 direction = (pic2.transform.position - planet.transform.position).normalized;
        //    planet.transform.Translate(direction * Time.deltaTime * mspeed);
        //    float dist = Vector3.Distance(planet.transform.position, centerBall.transform.position);
        //    if (dist <= maxGravDist)
        //    {
        //        Vector3 v = planet.transform.position - transform.position;
        //        //GetComponent<Rigidbody2D>().AddForce(v.normalized * (1.0f - dist / maxGravDist) * maxGravity);
        //        GetComponent<Rigidbody2D>().AddForce(transform.up * 10.0f);
        //    }
        //}

    }
}
