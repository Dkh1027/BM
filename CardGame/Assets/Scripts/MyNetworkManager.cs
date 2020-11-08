using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkManager : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log("Server start");
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Client connected");
    }
}
