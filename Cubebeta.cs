using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubebeta : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 700;
    public float leftright_speed = 250;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("0"))
        {
            rb.AddForce(leftright_speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("1"))
        {
            rb.AddForce(-leftright_speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
