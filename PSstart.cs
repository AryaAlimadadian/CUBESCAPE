using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSstart : MonoBehaviour
{
    public GameObject PS1;
    public GameObject PS2;

    void Update()
    {
        PS1.SetActive(true);
        PS2.SetActive(true);
    }
}
