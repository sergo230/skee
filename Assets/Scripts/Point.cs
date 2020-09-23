using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//send on gameobject "point"
public class Point : MonoBehaviour
{
    private SpawnerPoints spawnerPoints;
    private void Start()
    {
        spawnerPoints = GameObject.Find("SpawnerPoints").GetComponent<SpawnerPoints>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Invoke(nameof(spawn), 0.1f);
            StartCoroutine(spawn());
        }
    }

    private IEnumerator spawn()
    {
        yield return new WaitForSeconds(0.1f);
        spawnerPoints.spawn();
    }
}
