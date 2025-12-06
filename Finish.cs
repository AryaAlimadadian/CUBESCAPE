using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject Finishtext;
    public Transform player;
    void Update()
    {
        float s = player.position.z;
        if (s >= 9905f)
        {
            Finishtext.SetActive(true);
        }
    }
}
