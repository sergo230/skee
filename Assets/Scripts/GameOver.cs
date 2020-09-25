using System;
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
    public GameObject Enemys , Player;
    public Text ScoreT;
    public Text RecordT;
    public Text CoinsT;
    [HideInInspector] public int Timer;

    private void Start()
    {

        Tablet.SetActive(false);
        Enemys.SetActive(true);
        Player.SetActive(true);
        
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
                Lose();
                yield break;
            }

            yield return new WaitForSeconds(1f);
        }
    }

    public void Lose()
    {
        if(!Tablet.activeSelf)
        {
            Tablet.SetActive(true);
            Enemys.SetActive(false);
            Player.SetActive(false);
            
            ScoreT.text = ScoreAndRecord.ScoreAndRecords.GetScore().ToString();
            RecordT.text = ScoreAndRecord.ScoreAndRecords.GetRecord().ToString();
            CoinsT.text = CoinSpanwer._CoinSpanwer.coinLoadAndSave.coin.Coin.ToString();
            
            StartCoroutine(StopTime());
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