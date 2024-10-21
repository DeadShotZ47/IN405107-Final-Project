using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePanelManager : MonoBehaviour
{
    public void ChangeLevel(string lvlToLoad)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(lvlToLoad);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
