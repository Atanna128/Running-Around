using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class PauseToMenuScript : MonoBehaviour
{
    public Button pauseBtn;
    public GameObject MenuBar;
    public Button backToMenuBtn;
    public GameObject playGround;
    private PauseToMenuScript pauseScript;
    public bool isPause;
    private void Start()
    {
        isPause = false;
        playGround.GetComponent<ControllerScript>().SetPauseScriptReference(this);
    }
    public void OpenMenu()
    {
        
        MenuBar.GetComponent<CanvasRenderer>().SetAlpha(0.95f);
        if (MenuBar.activeSelf == false)
        {
            isPause = true;
            MenuBar.SetActive(true);
        }
        else
        {
            MenuBar.SetActive(false);
            isPause = false;
        }
        }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
