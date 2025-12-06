using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class createroomOne : MonoBehaviourPunCallbacks
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
    int op=2;
    int w = 0;
    int p = 0;
    

    void Start()
    {
        PhotonNetwork.JoinLobby();
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
        UpdateRoomList(roomList);
    }

    void UpdateRoomList(List<RoomInfo> list)
    {
        foreach (RoomItem item in roomItemsList)
        {
            Destroy(item.gameObject);
        }
        roomItemsList.Clear();

        foreach (RoomInfo room in list)
        {
            RoomItem newRoom = Instantiate(roomItemPrefab, contentObject);
            newRoom.SetRoomName(room.Name);
            roomItemsList.Add(newRoom);
        }
        Invoke("End", 1);
       
    }
    void End()
    {
        Done();
    }
    void Done()
    {
        DONE.SetActive(true);
    }
}
