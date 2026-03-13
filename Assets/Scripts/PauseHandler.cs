using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseHandler : MonoBehaviour
{
    
    public GameObject settingsPanel;
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void HideSettings()
    {
        settingsPanel.SetActive(false);
    }

    public void ShowMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
