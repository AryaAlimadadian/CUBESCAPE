using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class GameoverOnline : MonoBehaviour
{
    public GameObject GG;
    public GameObject PSstart;
    public GameObject PScontroller;
    public GameObject RotationCube;
    private bool gameover = false;
    public float restarttime = 5;
    public GameObject completelevel;
    public GameObject restart;
    public GameObject menu;
    public GameObject music;
    public GameObject restartingsound;
    public Transform Cube;
    PhotonView view;
    public GameObject pressspace;
    public GameObject time;
    public GameObject CubeMovement;
    public GameObject cube;
    public DigitalGlitch glitch;
    public AnalogGlitch glitchch;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    public void Completelevel()
    {
        completelevel.SetActive(true);
    }
    public void EndGame()
    {
        if (view.IsMine)
        {
            restart.SetActive(true);
            music.SetActive(false);
            restartingsound.SetActive(true);
            Invoke("Restart", restarttime);
        }
    }
    private void Restart()
    {
        if (view.IsMine)
        {
            PScontroller.SetActive(true);
            PSstart.SetActive(true);
            menu.SetActive(true);
            RotationCube.SetActive(true);
            restart.SetActive(false);
            glitch.enabled = false;
            pressspace.SetActive(true);
            time.SetActive(false);
            restartingsound.SetActive(false);
            Vector3 position = new Vector3(Random.Range(-6, 6), 0, 0);
            transform.position = Cube.position = position;
            transform.rotation = Cube.rotation = Quaternion.identity;
            Cursor.visible = true;
            GG.SetActive(true);
        }
    }
}
