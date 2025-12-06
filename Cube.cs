using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 700;
    public int rotatespeed = 700;
    public int rotatespeedgg = 700;
    public float leftright_speed = 250;
    int rotatey = 90;
    int j = 0;
    public GameObject pressspace;
    public GameObject time;
    public GameObject music;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {

            j=1;
            pressspace.SetActive(false);
            time.SetActive(true);
            music.SetActive(true);
            Cursor.visible = false;
        }
        if (j==1)
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("0") && j==1)
        {
            rotatey+=rotatespeed;
            rb.AddForce(leftright_speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if (60 < rotatey && rotatey < 120)
            {
                transform.Rotate(0, rotatespeed * Time.deltaTime, 0);
            }
        }
        if (Input.GetKey("1") && j==1)
        {
            rotatey -= rotatespeed;
            rb.AddForce(-leftright_speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if (60 < rotatey && rotatey < 120)
            {
                transform.Rotate(0, -rotatespeedgg * Time.deltaTime, 0);
            }
        }
    }
}
