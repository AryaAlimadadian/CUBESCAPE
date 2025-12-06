using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        transform.rotation = player.rotation = Quaternion.identity;
    }
}
