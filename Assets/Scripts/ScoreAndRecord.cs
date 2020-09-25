using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//send on gameobject "ScoreAndRecord"
public class ScoreAndRecord : MonoBehaviour
{
    public static ScoreAndRecord ScoreAndRecords { get; private set; }
    public Text ScoreT;
    [HideInInspector] public RecordLoadAndSave recordSaveAndLoad;
    private int score;
    private int record;

    private void Awake()
    {
        ScoreAndRecords = this;
        recordSaveAndLoad = GetComponent<RecordLoadAndSave>();
        recordSaveAndLoad.LoadRecord();
    }

    private void Start()
    {
        record = recordSaveAndLoad.recordCL.Record;
        score = 0;
        ShowScore();
    }

    /// <summary>
    /// score += editedScore
    /// </summary>
    /// <param name="editedScore"></param>
    public void ScoreEdited(int editedScore)
    {
        score += editedScore;
        ShowScore();
        if (score > record)
        {
            record = score;
            recordSaveAndLoad.recordCL.Record = record;
        }
    }

    public void ShowScore()
    {
        ScoreT.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }

    public int GetRecord()
    {
        return record;
    }
}