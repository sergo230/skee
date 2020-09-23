using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//send on gameobject "SpawnerEnemy"
public class EnemySpawner : Spawner
{
    public float TimeToSpawn;
    public GameObject parent;
    private void Start()
    {
        StartCoroutine(startSpawner());
    }

    public override void spawn()
    {
        base.spawn();
        spawningObj.transform.parent = parent.transform; 
        Destroy(spawningObj, 10f);
    }

    private IEnumerator startSpawner()
    {
        while (true)
        {
            spawn();
            yield return new WaitForSeconds(TimeToSpawn);
        }
    }
}