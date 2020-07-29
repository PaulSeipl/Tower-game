using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
   
    public void PlayLevel (string level) {
        SceneManager.LoadScene(level);
    }
  
    public void QuitGame () {
        Application.Quit();
    }
}
