using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public static Scene _Scene { get; private set; }

    private void Awake()
    {
        _Scene = this;
    }

    public void LoadScene(int idScene)
    {
        SceneManager.LoadScene(idScene);
    }

    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
}
