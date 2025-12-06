using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    public int done = 0;
    public GameObject panel;
    public GameObject music;

    public void Update()
    {
        panel.SetActive(true);
        music.SetActive(false);
        Invoke("Startgame2", done);
    }
    void Startgame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
