using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class UserName : MonoBehaviourPunCallbacks
{
    public TMP_InputField UserNameInput;
    public GameObject No;
    string gg;

    void Update()
    {
        gg = UserNameInput.text;
        if (gg.Length==0)
        {
            No.SetActive(true);
        }
        else
        {
            No.SetActive(false);
        }
    }
}
