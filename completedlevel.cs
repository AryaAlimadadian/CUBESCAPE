using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class completedlevel : MonoBehaviour
{
    int done = 1;
    public GameObject click;
    void Update()
    {
        Invoke("Done", done);
    }
    void Done()
    {
        click.SetActive(true);
    }
}
