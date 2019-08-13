using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel()
    {
        SceneManager.LoadScene("Play Scene 1");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}
