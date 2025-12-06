using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbySetting : MonoBehaviour
{
    public GameObject Lobby;
    public GameObject Setting;
    public void Settings()
    {
        Setting.SetActive(true);
        Lobby.SetActive(false);
    }
    public void Lobbygg()
    {
        Setting.SetActive(false);
        Lobby.SetActive(true);
    }
}
