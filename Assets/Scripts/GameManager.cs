using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public GameObject completeLevel;
    public GameObject pause;
    public void ComleteLevel()
    {
        completeLevel.SetActive(true);
        pause.SetActive(false);
        float t = Time.time;
        while (t < Time.time + 20f)
        {
            t += 1f;
        }
        //Time.timeScale = 0;
    }

    public void FinishGame()
    {

    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
