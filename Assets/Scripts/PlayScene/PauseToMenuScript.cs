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
    private PauseToMenuScript pauseScript;
    public bool isPause;
    private void Start()
    {
        isPause = false;
        playGround.GetComponent<ControllerScript>().SetPauseScriptReference(this);
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
