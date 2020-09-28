using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DELETE_PLAYERPREFS : MonoBehaviour
{
    public void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
