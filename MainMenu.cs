
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Demo");
    }
    public void ExitGame()
    {   
        Application.Quit();

    }

}