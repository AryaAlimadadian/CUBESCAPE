using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnectToServer1 : MonoBehaviourPunCallbacks
{
    public GameObject Start1;

    public void Start()
    {
        PhotonNetwork.Disconnect();
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        Invoke("END", 1);
    }
    void END()
    {
        Start1.SetActive(true);
    }
}
