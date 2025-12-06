using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicPanel : MonoBehaviour
{
    public GameObject panel;
    int time;
    void Start()
    {
        time=Random.Range(3, 5);
        Invoke("Now", time);
    }
    public void Now()
    {
        panel.SetActive(false);
    }
}
