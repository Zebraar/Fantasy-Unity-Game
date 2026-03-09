using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public GameObject settingsPanel;
    public GameObject gameInfoPanel;
    public GameObject howToPlayPanel;
    
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void SettingsMenuShow()
    {
        settingsPanel.SetActive(true);
    }

    public void SettingsMenuHide()
    {
        settingsPanel.SetActive(false);
    }

    public void GameInfoShow()
    {
        gameInfoPanel.SetActive(true);
    }

    public void GameInfoHide()
    {
        gameInfoPanel.SetActive(false);
    }

    public void HowToPlayShow()
    {
        howToPlayPanel.SetActive(true);
    }

    public void HowToPlayHide()
    {
        howToPlayPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
