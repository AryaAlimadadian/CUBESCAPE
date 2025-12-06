using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endlevel : MonoBehaviour
{
    private bool flag = false;
    public Gameover gameover;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Player")
        {
            gameover.Completelevel();
        }
    }
}

