using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using System.IO;
public class ControllerScript : MonoBehaviour
{
    public GameObject block; // will be modified
    public GameObject playGround;
    public GameObject player;
    public GameObject directionPlayer;
    public GameObject pauseBtn;
    public GameObject menuBar;

    public GameObject playerstats;
    public GameObject coin;
    public GameObject resumeBtn;
    public GameObject retryBtn;
    public GameObject backToLevelBtn;
    public GameObject listObject;
    
    private float lasttime;
    
    //public GameObject Circle1;
    public List<GameObject> blockList = new List<GameObject>(255);
    private PauseToMenuScript pauseScript;
    public float turnDirection = 0.8f;
    private float screenHeight = Screen.height;
    private float screenWidth = Screen.width;
    private MapData data = new MapData();
    public void SetPauseScriptReference(PauseToMenuScript pauseScript)
    {
        this.pauseScript = pauseScript;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        //loadMap();
        lasttime = Time.time;
        player.GetComponent<PlayerScript>().SetControllerScriptReference(this);
        directionPlayer.GetComponent<DirectionScript>().SetControllerScriptReference(this);
        menuBar.SetActive(true);
        resizeObject(menuBar, screenWidth / 1.5f, screenHeight / 1.5f);
        menuBar.SetActive(false);
        resizeObject(pauseBtn, screenWidth / 10, screenWidth / 10);
        resizeObject(resumeBtn, screenWidth / 10, screenWidth / 10);
        resizeObject(retryBtn, screenWidth / 10, screenWidth / 10);
        resizeObject(backToLevelBtn, screenWidth / 10, screenWidth / 10);
        resizeObject(playerstats, screenWidth / 10, screenWidth / 10);
        resizeObject(coin, screenWidth / 10, screenWidth / 10);

        // demo loadMap function
        //foreach(Transform child in round1.transform)
        //{
        //    if (child.GetSiblingIndex() != 0)
        //    {
        //        child.gameObject.SetActive(false);
        //    }
          
        //    child.tag = "JumpBlock";
        //}
        
    }
    
    private void loadMap()
    {
        string currentPath = Application.dataPath +  "/LevelJson/CurrentLevel.json";
        StreamReader stream = new StreamReader(currentPath);
        string json = stream.ReadToEnd();
        data = JsonUtility.FromJson<MapData>(json);
        foreach (Transform child in listObject.transform)
        {
            int index = child.GetSiblingIndex();
            SetUpBlock(child, data.list[index]);
        }


    }

    private void SetUpBlock(Transform child, int tagNum)
    {
        if(tagNum == 0)
        {
            child.GetComponent<Image>().color = Color.gray;
            child.transform.tag = "NormalBlock";
        }else if(tagNum == 1)
        {
            child.GetComponent<Image>().color = Color.cyan;
            child.transform.tag = "JumpBlock";
        }
    }


    // Update is called once per frame  
    void Update()
    {        
        float time = Time.time;       
        if(pauseScript.isPause == false)
        {
            playGround.transform.Rotate(new Vector3(0, 0, turnDirection));
        }        
    }

    public void changeDirection()
    {
        turnDirection *= -1;
    }


    private void resizeObject(GameObject obj,float multi1,float multi2)
    {
        var rectTransform = obj.transform as RectTransform;
        rectTransform.sizeDelta = new Vector2(multi1,multi2);
    }
}









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