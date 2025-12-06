using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class PrivateGG : MonoBehaviourPunCallbacks
{
    public GameObject panel;
    public void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        Invoke("Now",1);
    }
    public void Now()
    {
        panel.SetActive(false);
    }

}
