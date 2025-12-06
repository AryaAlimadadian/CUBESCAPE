using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class Dis : MonoBehaviourPunCallbacks
{

    public GameObject GG;
    public void Start()
    {
        PhotonNetwork.Disconnect();
        GG.SetActive(true);
    }
}
