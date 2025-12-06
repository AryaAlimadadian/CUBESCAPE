using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class JOINROOM : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.JoinLobby();
    }

}
