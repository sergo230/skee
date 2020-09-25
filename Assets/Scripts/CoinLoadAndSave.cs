﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CoinLoadAndSave : MonoBehaviour
{
   
    public string saveFileName;
    [HideInInspector] public _coin coin = new _coin();
    private string path;
    [HideInInspector]
    public void LoadCoins()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.persistentDataPath, saveFileName + ".json");

#else
        path = Path.Combine(Application.dataPath, saveFileName + ".json");
#endif
        if (File.Exists(path))
        {
            coin = JsonUtility.FromJson<_coin>(File.ReadAllText(path));
        }
        else
        {
            coin.Coin = 0;
        }
    }

    public void SaveCoin()
    {
        File.WriteAllText(path, JsonUtility.ToJson(coin));
    }

#if UNITY_ANDROID && !UNITY_EDITOR
    private void OnApplicationPause(bool pauseStatus)
    {
        if(pauseStatus) SaveCoin();
    }
#endif
    private void OnApplicationQuit()
    {
        SaveCoin();
    }
}
