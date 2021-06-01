using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("QUITING GAME!...");
        Application.Quit();
    }
}
