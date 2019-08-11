using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject block;
    public GameObject playGround;
    private float lasttime;
    public GameObject pic2;

    public List<GameObject> blockList = new List<GameObject>();
    float maxGravDist = 4.0f;
    float maxGravity = 35.0f;

    float mspeed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        lasttime = Time.time;
        // creating sample object for collider
        for (int i = 0; i < 10; i++)
        {
            GameObject newobj = (GameObject)Instantiate(block) as GameObject;
            blockList.Add(newobj);
            newobj.transform.position = new Vector2(400 + 30 * i, 400);
            var theBarRectTransform = newobj.transform as RectTransform;
            theBarRectTransform.sizeDelta = new Vector2(20, 20);
            newobj.transform.SetParent(playGround.transform);
            pic2.transform.Rotate(new Vector3(0, 0, 2f));
        }
        
    }

    // Update is called once per frame
   
    void Update()
    {
        
        float time = Time.time;
        //if((time-lasttime) >0.5)
        //{
        //    //create sampleobject
        //    GameObject newobj = (GameObject)Instantiate(block) as GameObject;
        //    //listGrid.Add(newobj);
        //    newobj.transform.position = new Vector2(600, 450);
        //    var theBarRectTransform = newobj.transform as RectTransform;
        //    theBarRectTransform.sizeDelta = new Vector2(20, 20);
        //    newobj.transform.SetParent(playGround.transform);
        //    lasttime = time;
        ////}
        //playGround.transform.Rotate(new Vector3(00, 0,0.2f));
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
