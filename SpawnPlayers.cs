using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    public float minX;
    public float maxX;
    public float y;
    public float z;

    private void Start()
    {
        Vector3 position = new Vector3(Random.Range(minX, maxX), y, z);
        PhotonNetwork.Instantiate(playerPrefab.name, position, Quaternion.identity);
    }
}
