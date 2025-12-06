using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public GameObject gg;
    public void Start()
    {
        gg.SetActive(true);
    }
}
