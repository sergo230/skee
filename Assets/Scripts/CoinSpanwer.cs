using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpanwer : Spawner
{
    public static CoinSpanwer _CoinSpanwer { get; private set; }
    public float TimeToDestroyCoin;
    public float TimeToSpawnCoin;

    private void Awake()
    {
        _CoinSpanwer = this;
    }

    public override void spawn()
    {
        base.spawn();
        Destroy(spawningObj,TimeToDestroyCoin);
    }

    private IEnumerator spawnCoin()
    {
        if (spawningObj != null)
        {
            //TODO : add coins
            Destroy(spawningObj);
        }
        yield return new WaitForSeconds(TimeToSpawnCoin);
        spawn();
    }
}
