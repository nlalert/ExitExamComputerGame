using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {
    public string gameSceneName = "GameStage";
    public GameObject settingsPanel;
    public GameObject creditsPanel;

    // Load the game scene to start the game
    public void StartGame() {
        SceneManager.LoadScene(gameSceneName);
    }

    // Open the settings panel in the main menu
    public void OpenSettings() {
        settingsPanel.SetActive(true);
    }

    // Close the settings panel in the main menu
    public void CloseSettings() {
        settingsPanel.SetActive(false);
    }

    // Open the credits panel in the main menu
    public void OpenCredits() {
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    // Close the credits panel in the main menu
    public void CloseCredits() {
        creditsPanel.SetActive(false);
    }

    // Exit the game
    public void ExitGame() {
        Application.Quit();
    }
}
