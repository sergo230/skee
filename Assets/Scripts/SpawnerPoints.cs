using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;


//send on gameobject "SpawnerPoints"
public class SpawnerPoints : Spawner
{
    private ScoreAndRecord scoreAndRecord;
    private GameOver gameOver;
    private Acceleration acceleration;
    private void Start()
    {
        scoreAndRecord = GameObject.Find("ScoreAndRecord").GetComponent<ScoreAndRecord>();
        gameOver = GameObject.Find("GameOver").GetComponent<GameOver>();
        acceleration = GameObject.Find("Acceleration").GetComponent<Acceleration>();
        spawn();
    }

    public override void spawn()
    {
        if (spawningObj != null)
        {
            gameOver.updatingTimer();
            gameOver.ShowTimer();
            acceleration.SpeedUpTime(0.05f);
            print("ScaleTime = "+Time.timeScale);
            scoreAndRecord.ScoreEdited(1);
            Destroy(spawningObj);
        }
        base.spawn();
    }
}
