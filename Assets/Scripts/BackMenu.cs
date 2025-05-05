using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMenu : MonoBehaviour
{
    public GameObject PanelStart;
    public GameObject PanelLevels;

    public void BackToMenu()
    {
        PanelStart.SetActive(true);
        PanelLevels.SetActive(false);
    }
}
