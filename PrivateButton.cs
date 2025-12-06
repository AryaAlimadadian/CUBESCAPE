using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivateButton : MonoBehaviour
{
    public GameObject Controller;
    public GameObject Controller2;
    public void Start()
    {
        Controller.SetActive(true);
        Controller2.SetActive(true);
    }
}
