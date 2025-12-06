using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barkhordwall : MonoBehaviour
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
        if (collisioninfo.collider.tag == "cube")
        {
            glitchsound.SetActive(true);
            glitchch.enabled = true;
        }
        Invoke("hit", done);
    }
    private void hit()
    {
        glitchch.enabled = false;
        glitchsound.SetActive(false);
    }
}
