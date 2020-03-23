using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isOver = false;
    public float restartDelay = 1f;
    public GameObject levelCompletedUI;

    public void LevelComplete()
    {
        levelCompletedUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!isOver) 
        { 
            isOver = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
