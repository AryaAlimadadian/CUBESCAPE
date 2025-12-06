using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class PublicServer : MonoBehaviour
{
    public TMP_Text joinInput;
    public TMP_InputField createInput;

    void Update()
    {
        Debug.Log(createInput.text);
        joinInput.text= createInput.text;
    }
}
