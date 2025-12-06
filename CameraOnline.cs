using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnline : MonoBehaviour
{
    public Transform camera;
    void Update()
    {
        transform.rotation = camera.rotation = Quaternion.identity;
    }
}
