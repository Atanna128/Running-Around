using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class PauseToMenuScript : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject MenuBar;
    public Button backToMenuBtn;
    public GameObject playGround;
    public GameObject textcoin;
    public GameObject player;
    public bool isPause;
    private void Start()
    {
        isPause = false;
        playGround.GetComponent<ControllerScript>().SetPauseScriptReference(this);
    }

    private void Update()
    {
        string num = player.GetComponent<PlayerScript>().coin.ToString();
        textcoin.GetComponent<Text>().text = num;
        Debug.Log(textcoin.GetComponentInChildren<Text>().text);
        
    }
    public void OpenMenu()
    {
        pauseBtn.gameObject.SetActive(false);
        MenuBar.GetComponent<CanvasRenderer>().SetAlpha(0.95f);
        if (MenuBar.activeSelf == false)
        {
            isPause = true;
            MenuBar.SetActive(true);
        }
        
        }

    public void BackToLevel()
    {
        SceneManager.LoadScene("Level Scene");
    }

    public void Resume()
    {
        pauseBtn.gameObject.SetActive(true);
        isPause = false;
        MenuBar.SetActive(false);
    }

    public void Retry()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}


///level x 
///complete/fail? pause status
///taps/point
///total point ?