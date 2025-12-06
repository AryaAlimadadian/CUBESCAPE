using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField] private Material materialColor;
    int color1;
    int color2;
    int color3;
    void Update()
    {
        Invoke("SetColor", 10);
    }
    void SetColor()
    {
        color1 = Random.Range(0, 255);
        color2 = Random.Range(0, 255);
        color3 = Random.Range(0, 255);
        Debug.Log(color1);
        Debug.Log(color2);
        Debug.Log(color3);
        materialColor.color = new Color (color1, color2, color3);
        Invoke("Update", 10);
    }
}
