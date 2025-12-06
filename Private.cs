using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class Private : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;
    public Dropdown MaxPlayer;
    int gg = 0;

    public void CreateRoom()
    {
        int Players = MaxPlayer.value;
        gg = Players + 2;
        if (gg == 2)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 2, IsVisible = true });
        }
        if (gg == 3)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 3, IsVisible = true });
        }
        if (gg == 4)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 4, IsVisible = true });
        }
        if (gg == 5)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 5, IsVisible = true });
        }
        if (gg == 6)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 6, IsVisible = true });
        }
        if (gg == 7)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 7, IsVisible = true });
        }
        if (gg == 8)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 8, IsVisible = true });
        }
        if (gg == 9)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 9, IsVisible = true });
        }
        if (gg == 10)
        {
            PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 10, IsVisible = true });
        }
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("online level");
    }

}
