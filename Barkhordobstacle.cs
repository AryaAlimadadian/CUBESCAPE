using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barkhordobstacle : MonoBehaviour
{
    public Cube movement;
    public GameObject cube;
    public DigitalGlitch glitch;
    public AnalogGlitch glitchch;
    public GameObject glitchsound;
    public Quaternion Roffset;
    public Transform player;
    float done = 0.25f;
    int flag = 0;
    int flag2 = 0;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            glitch.enabled = true;
            FindObjectOfType<Gameover>().EndGame();
            flag2 = 1;
        }
    }
    void Update()
    {
        if (flag2 == 0)
        {
            transform.rotation = player.rotation = Roffset;
        }
    }
}