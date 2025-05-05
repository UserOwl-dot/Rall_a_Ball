using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject panel;
    public GameObject pausemenu;
    
    public void Pause()
    {
        panel.SetActive(true);
        pausemenu.SetActive(false);
        Time.timeScale = 0;
    }
}
