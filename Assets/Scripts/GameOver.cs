﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//send on gameobject "GameOver"
public class GameOver : MonoBehaviour
{
    public int ValueUpdatingTimer;
    public Text TimerT;
    public GameObject Tablet;
    public Text ScoreT;
    [HideInInspector] public int Timer;
    private ScoreAndRecord scoreAndRecord;

    private void Start()
    {
        scoreAndRecord = GameObject.Find("ScoreAndRecord").GetComponent<ScoreAndRecord>();

        Tablet.SetActive(false);
        StartCoroutine(updateTimer());
        ShowTimer();
    }

    public void ShowTimer()
    {
        TimerT.text = Timer.ToString();
    }


    public void updatingTimer()
    {
        Timer = ValueUpdatingTimer;
    }

    private IEnumerator updateTimer()
    {
        updatingTimer();
        while (true)
        {
            Timer--;
            ShowTimer();
            if (Timer <= 0)
            {
                Tablet.SetActive(true);
                ScoreT.text = scoreAndRecord.GetScore().ToString();
                StartCoroutine(StopTime());
                yield break;
            }

            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator StopTime()
    {
        yield return new WaitForSeconds(1.5f);
        Time.timeScale = 0;
    }

    public void RestartFuckingLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}