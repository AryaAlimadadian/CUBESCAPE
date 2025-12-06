using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDone : MonoBehaviour
{
    float done = 2.5f;
    public GameObject wall1000;
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "wallgg")
        {
            Invoke("Done", done);
        }
    }
    void Done()
    {
        wall1000.SetActive(false);
    }
}
