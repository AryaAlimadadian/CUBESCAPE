using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGG : MonoBehaviour
{
    public GameObject GG;
    public GameObject Lobby;

    public void gg()
    {
        GG.SetActive(true);
        Lobby.SetActive(false);
    }

    public void LOBBY()
    {
        GG.SetActive(false);
        Lobby.SetActive(true);
    }
}
