using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class createroom120 : MonoBehaviourPunCallbacks
{
    public GameObject DONE;
    public TMP_InputField createInput;
    public TMP_InputField joinInput;
    public RoomItem roomItemPrefab;
    List<RoomItem> roomItemsList = new List<RoomItem>();
    public Transform contentObject;
    public Dropdown MaxPlayer;
    int gg = 0;
    int flag;
    int t = 0;
    int op = 2;
    int w = 0;
    int p = 0;
    int PrivateFlag = 0;


    public void PrivateButton()
    {
        PrivateFlag = 1;
    }

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

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("online level");
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        int LenList = roomList.Count;
        Debug.Log(LenList);
        UpdateRoomList(roomList);
    }

    void UpdateRoomList(List<RoomInfo> list)
    {
        Debug.Log(PrivateFlag);
        foreach (RoomItem item in roomItemsList)
        {
            Destroy(item.gameObject);
        }
        roomItemsList.Clear();


        foreach (RoomInfo room in list)
        {
            if (PrivateFlag == 1)
            {
                RoomItem newRoom = Instantiate(roomItemPrefab, contentObject);
                newRoom.SetRoomName(room.Name);
                roomItemsList.Add(newRoom);
            }
        }
        Invoke("Done", 1);
    }
    void Done()
    {
        DONE.SetActive(true);
    }
}
