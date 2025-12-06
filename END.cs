using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END : MonoBehaviour
{
    public int end;
    public GameObject Music;
    void Update()
    {
        Music.SetActive(false);
        Invoke("Done",end);
    }
    private void Done()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Cursor.visible = true;
    }
}
