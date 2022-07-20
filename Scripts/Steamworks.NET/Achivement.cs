using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class Achivement : MonoBehaviour
{
    public static Achivement instance;
    
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance !=this)
        {
            Destroy(gameObject);
        }
    }


    public void UnlockAchievement(string id)
    {
        if (!SteamManager.Initialized)
            return;

        SteamUserStats.SetAchievement(id);

        SteamUserStats.StoreStats();
    }


    public void SetStat(string id, int value)
    {
        if (!SteamManager.Initialized)
            return;


        SteamUserStats.SetStat(id, value);
        SteamUserStats.StoreStats();
    }
}
