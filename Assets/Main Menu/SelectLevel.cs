using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{

    public string LoadLevel;

    public void StartGame()
    {

        Application.LoadLevel(LoadLevel);
    }
}
