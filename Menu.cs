using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Menuicon;
    public GameObject Paused;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Back;
    public GameObject Space;
    // Start is called before the first frame update
    public void Start()
    {
        Menuicon.SetActive(false);
        Paused.SetActive(true);
        Button1.SetActive(true);
        Button2.SetActive(true);
        Button3.SetActive(true);
        Back.SetActive(true);
        Space.SetActive(false);
    }
    public void Stop()
    {
        Menuicon.SetActive(true);
        Paused.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
        Back.SetActive(false);
        Space.SetActive(true);
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
