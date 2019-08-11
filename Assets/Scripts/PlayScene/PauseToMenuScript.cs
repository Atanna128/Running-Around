using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseToMenuScript : MonoBehaviour
{
    public Button pauseBtn;
    public GameObject MenuBar;
    public Button backToMenuBtn;
    public void OpenMenu()
    {
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
