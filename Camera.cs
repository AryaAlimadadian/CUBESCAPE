using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Cube movement;
    public Rigidbody rb;
    public float speed = 700;
    public Transform cube;
    public Transform player;
    public Transform camera;
    public Vector3 offset;
    public Vector3 offset2;
    Vector3 offset3;
    int flag=0;
    // Update is called once per frame
    void Update()
    {
        float s = player.position.z;
        offset3 = offset2 - offset;
        if ((s/1 > 970f && s/1 < 1050f) || (s / 1 > 1970f && s / 1  <  2050f) || (s / 1 > 2970f && s/1 < 3050f) || (s / 1 > 3970f && s / 1 < 4050f) || (s / 1 > 4970f && s / 1 < 5050f) || (s / 1 > 5970f && s / 1 < 6050f) || (s / 1 > 6970f && s / 1 < 7050f) || (s / 1 > 7970f && s / 1 < 8050f) || (s / 1 > 8970f && s / 1 < 9050f) || (s / 1 > 9990f && s / 1 < 10100f))
        {
            movement.enabled = false;
            rb.AddForce(0, 0, speed * Time.deltaTime);
            transform.position = camera.position + offset2;
        }
        else
        {
            movement.enabled = true;
            transform.position = player.position + offset;
        }
    }
}
