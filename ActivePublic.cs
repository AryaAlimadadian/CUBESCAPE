using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePublic : MonoBehaviour
{
    public GameObject gg;
    public GameObject gg1;
    public void Start()
    {
        gg.SetActive(true);
        gg1.SetActive(true);
    }
}
