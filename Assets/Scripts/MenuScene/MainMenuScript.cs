using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainMenuScript : MonoBehaviour
{
    public Button quitBtn;
    public GameObject mainMenu;

    private void Start()
    {
        MapData data = new MapData();
        string[] level = new string[10]; //example 10 maps
        SaveSystem.GenerateMap(data, level[0]);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
}
