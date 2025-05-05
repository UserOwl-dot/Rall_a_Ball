using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject pausemenu;

    public void Continue()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
        pausemenu.SetActive(true);
    }
}
