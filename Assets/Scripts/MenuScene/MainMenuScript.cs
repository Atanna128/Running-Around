using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Button quitBtn;
    public GameObject mainMenu;
    public void PlayGame()
    {
        SceneManager.LoadScene("Level Scene");
    }

    public void QuitGame()
    {
        //Application.Quit();
    }

    
}
