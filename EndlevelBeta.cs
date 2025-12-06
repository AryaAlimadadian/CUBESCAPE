using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlevelBeta : MonoBehaviour
{
    private bool flag = false;
    public Gameover gameover;

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            gameover.Completelevel();
        }
    }
}
