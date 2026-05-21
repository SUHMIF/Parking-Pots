using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public int sceneToLoad;

    public void backButton()
    {
        SceneManager.LoadScene(sceneToLoad);
        Time.timeScale = 1; // Temporary UNPause
    }
}