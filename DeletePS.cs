using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePS : MonoBehaviour
{
    public GameObject PS1;
    public GameObject PS2;
    public GameObject gg1;
    public GameObject gg2;
    float time = 0.01f;

    void Update()
    {
        PS1.SetActive(false);
        PS2.SetActive(false);
        Invoke("now", time);
    }
    void now()
    {
        gg1.SetActive(false);
        gg2.SetActive(false);
    }
}
