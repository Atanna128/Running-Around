using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelMenuScript : MonoBehaviour
{
    public GameObject backBtn;
    private float screenHeight = Screen.height;
    private float screenWidth = Screen.width;
    // Start is called before the first frame update
    private void Start()
    {
        var backBtnRectTransform = backBtn.transform as RectTransform;
        backBtnRectTransform.sizeDelta = new Vector2(screenWidth / 4, screenWidth / 4);
    }
    public void LoadLevel(Button btn)
    {//bug ne
        string name = btn.name;
        MapData data = new MapData();
        data = SaveSystem.LoadMap(name);
        SaveSystem.SaveMap(data, "CurrentLevel");
        SceneManager.LoadScene(name);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}
