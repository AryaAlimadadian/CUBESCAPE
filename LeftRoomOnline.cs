using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class LeftRoomOnline : MonoBehaviourPunCallbacks
{
    string NickName;
    public void SetPlayerInfo(Player _player)
    {
        NickName = _player.NickName;
    }
    public void OnLeaveRoom()
    {
        Debug.Log(NickName);
        Debug.Log(NickName + " Left room");
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.Disconnect();
    }
}
