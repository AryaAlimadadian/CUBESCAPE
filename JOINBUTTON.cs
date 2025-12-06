using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JOINBUTTON : MonoBehaviour
{
    public GameObject Lobby;
    public GameObject Join;

    public void Start()
    {
        Lobby.SetActive(false);
        Join.SetActive(true);
    }
}
