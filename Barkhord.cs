using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barkhord : MonoBehaviour
{
    public GameObject CubeMovement;
    public GameObject cube;
    public DigitalGlitch glitch;
    public AnalogGlitch glitchch;
    public GameObject glitchsound;
    public Quaternion Roffset;
    public Transform player;
    float done = 0.25f;
    int flag=0;
    int flag2 = 0;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag=="obstacle")
        {
            CubeMovement.SetActive(false);
            glitch.enabled = true;
            FindObjectOfType<Gameover>().EndGame();
            flag2 = 1;
        }
        if (collisioninfo.collider.tag == "wall")
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
    void Update()
    {
        if (flag2 == 0)
        {
            transform.rotation = player.rotation = Roffset;
        }
    }
}
