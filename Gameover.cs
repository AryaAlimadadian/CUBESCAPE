using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    private bool gameover = false;
    public int restarttime = 5;
    public GameObject completelevel;
    public GameObject restart;
    public GameObject music;
    public GameObject restartingsound;

    public void Completelevel ()
    {
        completelevel.SetActive(true);
    }
    public void EndGame()
    {
        if (gameover==false)
        {
            gameover = true;
            restart.SetActive(true);
            music.SetActive(false);
            restartingsound.SetActive(true);
            Invoke("Restart",restarttime);
        }
    }
    private void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Cursor.visible = true;
    }
}
