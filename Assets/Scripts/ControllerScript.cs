using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject block;
    public GameObject playGround;
    private float lasttime;
    // Start is called before the first frame update
    void Start()
    {
        lasttime = Time.time;
        // creating sample object for collider
        for(int i = 0; i < 10; i++) {
            GameObject newobj = (GameObject)Instantiate(block) as GameObject;
            //listGrid.Add(newobj);
            newobj.transform.position = new Vector2(400 + 30 * i, 400);
            var theBarRectTransform = newobj.transform as RectTransform;
            theBarRectTransform.sizeDelta = new Vector2(20, 20);
            newobj.transform.SetParent(playGround.transform);
            //newobj.GetComponent<BoxCollider2D>().size = new Vector2(20, 20);
        }
    }

    // Update is called once per frame
   
    void Update()
    {
        float time = Time.time;
        if((time-lasttime) >0.5)
        {
            //create sampleobject
            GameObject newobj = (GameObject)Instantiate(block) as GameObject;
            //listGrid.Add(newobj);
            newobj.transform.position = new Vector2(400, 400);
            var theBarRectTransform = newobj.transform as RectTransform;
            theBarRectTransform.sizeDelta = new Vector2(20, 20);
            newobj.transform.SetParent(playGround.transform);
            lasttime = time;
        }
        playGround.transform.Rotate(new Vector3(00, 0,0.2f));
    }
}
