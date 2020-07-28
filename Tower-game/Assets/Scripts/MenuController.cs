using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string mainMenuScene;
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public GameObject gameOverScreen;
    public GameObject score;
    public static bool isPaused;

    // Update is called once per frame
    void Update()
    {
        if (TowerLivesController.gameOver)
        {
            gameOverScreen.SetActive(true);
            Destroy(score);
        }
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            } else
            {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void ResumeGame(){
        isPaused = false;
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ResumeGame();
    }
    public void ReturnToMain() {
        ResumeGame();
        SceneManager.LoadScene(mainMenuScene);  
    }
}
