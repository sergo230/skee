using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//send on gameobject "ScoreAndRecord"
public class ScoreAndRecord : MonoBehaviour
{
    public Text ScoreT;
    private int score;

    private void Start()
    {
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
    }

    public void ShowScore()
    {
        ScoreT.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
