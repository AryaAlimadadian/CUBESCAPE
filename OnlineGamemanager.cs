using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class OnlineGamemanager : MonoBehaviour
{
    public void Restart()
    {
        PhotonNetwork.LoadLevel("online level");
    }
}
