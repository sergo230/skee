using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float SpeedMovement;

    private void FixedUpdate()
    {
        moveEnemy();
    }

    private void moveEnemy()
    {
        transform.Translate(Vector3.right * SpeedMovement);
    }
}
