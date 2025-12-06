using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject Menu;

    void Update()
    {
        if (Input.GetKey("space"))
        {
            Menu.SetActive(false);
        }
    }
}
