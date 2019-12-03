using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public void LoadScene(string SceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
    }

    public void SceneLoader(string SceneString)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneString);
    }

    internal static void LoadScene(object buildIndex)
    {
        throw new NotImplementedException();
    }

    internal static object GetActiveScene()
    {
        throw new NotImplementedException();
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
