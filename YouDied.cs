
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDied : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Demo");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
