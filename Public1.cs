using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class Public1 : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("Public1");
    }
}
