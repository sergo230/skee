using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

//send on gameobject "ScoreAndRecord"
public class RecordLoadAndSave : MonoBehaviour
{
    public string saveFileName;
    [HideInInspector] public record recordCL = new record();
    private string path;
[HideInInspector]
    public void LoadRecord()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.persistentDataPath, saveFileName + ".json");

#else
        path = Path.Combine(Application.dataPath, saveFileName + ".json");
#endif
        if (File.Exists(path))
        {
            recordCL = JsonUtility.FromJson<record>(File.ReadAllText(path));
        }
        else
        {
            recordCL.Record = 0;
        }
    }

    public void SaveRecord()
    {
        File.WriteAllText(path, JsonUtility.ToJson(recordCL));
    }

#if UNITY_ANDROID && !UNITY_EDITOR
    private void OnApplicationPause(bool pauseStatus)
    {
        if(pauseStatus) SaveRecord();
    }
#endif
    private void OnApplicationQuit()
    {
        SaveRecord();
    }
}