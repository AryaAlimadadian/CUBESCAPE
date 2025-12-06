using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoomItem : MonoBehaviour
{
    public TMP_Text roomName;

    public void SetRoomName(string _roomName)
    {
        roomName.text = _roomName;
    }
}
