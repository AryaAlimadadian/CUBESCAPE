using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BACKBUTTON : MonoBehaviour
{
    public GameObject Lobby;
    public GameObject Join;
    public GameObject Create;

    public void Start()
    {
        Lobby.SetActive(true);
        Join.SetActive(false);
        Create.SetActive(false);
    }
}
