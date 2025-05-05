using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public GameObject PanelStart;
    public GameObject PanelLevels;
    
    public void GoLevels()
    {
        PanelStart.SetActive(false);
        PanelLevels.SetActive(true);
    }
}
