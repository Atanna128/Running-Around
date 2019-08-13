using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel(Button btn)
    {
        string name = btn.name;
        SceneManager.LoadScene(name);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}
