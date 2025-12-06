using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadnextlevel : MonoBehaviour
{
    public int end;
    public GameObject endone;
    public GameObject endtwo;
    public GameObject escape;
    public GameObject talk;
    public GameObject click;
    void Update()
    {
        Debug.Log(0);
        endone.SetActive(false);
        endtwo.SetActive(false);
        escape.SetActive(false);
        talk.SetActive(false);
        if (click.active == true)
        {
            if (Input.GetMouseButton(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
