using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    public GameObject Private;
    public GameObject Public;
    public GameObject Create;
    public GameObject Create1;
    public GameObject Join;
    public GameObject Join1;

    public void Privategg()
    {
        Private.SetActive(true);
        Public.SetActive(false);
        Create.SetActive(false);
        Create1.SetActive(true);
        Join.SetActive(false);
        Join1.SetActive(true);
    }

    public void Publicgg()
    {
        Private.SetActive(false);
        Public.SetActive(true);
        Create.SetActive(false);
        Create1.SetActive(true);
        Join.SetActive(false);
        Join1.SetActive(true);
    }
}
