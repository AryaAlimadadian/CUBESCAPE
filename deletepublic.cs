using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
public class deletepublic : MonoBehaviourPunCallbacks
{
    void Start()
    {
        string name = PhotonNetwork.CurrentRoom.Name;
        Debug.Log(name);
    }
}
