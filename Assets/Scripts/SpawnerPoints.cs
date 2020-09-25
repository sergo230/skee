using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;


//send on gameobject "SpawnerPoints"
public class SpawnerPoints : Spawner
{
    public static SpawnerPoints SpawnerPoint { get; private set; }
    private GameOver gameOver;
    private Acceleration acceleration;

    private void Awake()
    {
        SpawnerPoint = this;
    }

    private void Start()
    {
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
            ScoreAndRecord.ScoreAndRecords.ScoreEdited(1);
            Destroy(spawningObj);
        }

        base.spawn();
    }
}