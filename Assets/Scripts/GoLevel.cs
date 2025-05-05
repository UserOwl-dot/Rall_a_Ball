using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLevel : MonoBehaviour
{   
    public void LevelFirst()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1.0f;
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1.0f;
    }
}
