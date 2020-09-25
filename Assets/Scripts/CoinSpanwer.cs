using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSpanwer : Spawner , ICoin
{
    public Text CoinT;
    public static CoinSpanwer _CoinSpanwer { get; private set; }
    public float TimeToDestroyCoin;
    public float TimeToSpawnCoin;
    public CoinLoadAndSave coinLoadAndSave { get; private set; }

    private void Awake()
    {
        _CoinSpanwer = this;
    }

    private void Start()
    {
        coinLoadAndSave = GetComponent<CoinLoadAndSave>();
        coinLoadAndSave.LoadCoins();
        ShowCoins(coinLoadAndSave.coin.Coin);
        StartCoroutine(spawnCoin());
    }

    public override void spawn()
    {
        base.spawn();
        Destroy(spawningObj,TimeToDestroyCoin);
    }

    private IEnumerator spawnCoin()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeToSpawnCoin);
            if (spawningObj != null)
            {
                Destroy(spawningObj);
            }
            spawn();
        }
    }

    public void ShowCoins(int coins)
    {
        CoinT.text = coins.ToString();
    }

    public void TouchPlayerCoin()
    {
        if (spawningObj != null)
        {
            coinLoadAndSave.coin.Coin++;
            ShowCoins(coinLoadAndSave.coin.Coin);
            Destroy(spawningObj);
        }
    }

}
