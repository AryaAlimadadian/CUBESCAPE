using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveobstacle : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 100;
    private bool gg = false;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x>=-2.6)
        {
            if (gg==false)
            {
                rb.AddForce(-speed * Time.deltaTime, 0, 0);
            }
        }
        if (transform.position.x <= -2.6)
        {
            gg = true;
        }
        if (transform.position.x <= 2.6)
        {
            if (gg==true)
            {
                rb.AddForce(speed * Time.deltaTime, 0, 0);
            }
        }
        if (transform.position.x >= 2.6)
        {
            gg = false;
        }
    }
}
