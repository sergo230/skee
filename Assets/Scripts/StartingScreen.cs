using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScreen : MonoBehaviour
{
    public float TimeToStartGame;
    private void Start()
    {
        StartCoroutine(GoToGame());
    }

    private IEnumerator GoToGame()
    {
        yield return new WaitForSeconds(TimeToStartGame);
        Scene._Scene.LoadScene(1);
    }
}
