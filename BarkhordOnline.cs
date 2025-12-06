using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BarkhordOnline : MonoBehaviour
{
    public GameObject GG;
    public GameObject CubeMovement;
    public GameObject cube;
    public GameObject RotationCube;
    public DigitalGlitch glitch;
    public AnalogGlitch glitchch;
    public GameObject glitchsound;
    public Quaternion Roffset;
    public Transform player;
    float done = 0.25f;
    int flag = 0;
    int flag2 = 0;
    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            if (view.IsMine)
            {
                FindObjectOfType<GameoverOnline>().EndGame();
            }
            CubeMovement.SetActive(false);
            RotationCube.SetActive(false);
            GG.SetActive(false);
            glitch.enabled = true;
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
}

