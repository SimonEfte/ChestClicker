using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facepunch : MonoBehaviour
{
    public static bool noSteamInt;

    
    public void Awake()
    {
        noSteamInt = false;
    }

    private void Start()
    {
        if(noSteamInt == false)
        {
            Steamworks.SteamClient.Init(2422090);
        }
    }

    private void Update()
    {
        if (noSteamInt == false)
        {
            Steamworks.SteamClient.RunCallbacks();
        }
    }

    private void OnApplicationQuit()
    {
        if (noSteamInt == false)
        {
            Steamworks.SteamClient.Shutdown();
        }
    }
    
}
