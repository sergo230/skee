using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void SpeedUpTime(float timeAcceleration)
    {
        Time.timeScale += timeAcceleration;
    }
}
