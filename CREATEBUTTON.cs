using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREATEBUTTON : MonoBehaviour
{
    public GameObject Lobby;
    public GameObject Create;

    public void Start()
    {
        Lobby.SetActive(false);
        Create.SetActive(true);
    }
}
