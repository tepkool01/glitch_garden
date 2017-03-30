using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_New_Level : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    public void Start()
    {
        if (autoLoadNextLevelAfter == 0)
        {
            Debug.Log("Auto Load Disabled.");
        } else
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
    }

	public void load_da_scene(string sceneName)
    {
        print("Loading Scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void LoadNextLevel()
    {
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
