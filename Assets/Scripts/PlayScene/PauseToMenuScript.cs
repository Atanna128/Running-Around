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
    public void OpenMenu()
    {
        MenuBar.GetComponent<CanvasRenderer>().SetAlpha(0.4f);
     
        if (MenuBar.activeSelf == false)
        {
            MenuBar.SetActive(true);
        }
        else MenuBar.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
