using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStart : MonoBehaviour
{
    public GameObject starter;
    public GameObject pause;
    public void Firststart()
    {
        Time.timeScale = 1f;
        starter.SetActive(false);
        pause.SetActive(true);
    }
}
