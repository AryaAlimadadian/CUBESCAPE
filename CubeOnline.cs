using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CubeOnline : MonoBehaviour
{
    public GameObject CubeMovement;
    public GameObject all;
    public GameObject all2;
    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetKey("space"))
            {
                CubeMovement.SetActive(true);
            }
            all.SetActive(true);
            all2.SetActive(true);
        }
    }
}

