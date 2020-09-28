using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    public GameObject TrainingTablet;
    public GameObject FirstElement;
    private int endTraining;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("endTraining"))
        {
            if (PlayerPrefs.GetInt("endTraining") == 0)
            {
                TrainingTablet.SetActive(true);
                FirstElement.SetActive(true);
                endTraining = 0;
                Time.timeScale = 0;
            }
            else
            {
                TrainingTablet.SetActive(false);
                endTraining = 1;
            }
        }
        else
        {
            TrainingTablet.SetActive(false);
        }
    }

    /*
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            PlayerPrefs.DeleteAll();
        }
    }
     */
    public void SetActiveFalse(GameObject Obj)
    {
        Obj.SetActive(false);
    }

    public void SetActiveTrue(GameObject Obj)
    {
        Obj.SetActive(true);
    }

    public void StartGame()
    {
        endTraining = 1;
        PlayerPrefs.SetInt("endTraining", 1);
        Time.timeScale = 1;
    }
}