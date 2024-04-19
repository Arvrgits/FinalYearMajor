using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class PauseMenu : MonoBehaviour
{
    public XRController leftController;
    public XRController rightController;

    private bool isPaused = false;

   void TogglePause(SelectEnterEventArgs args)
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; // Pause the game
            // Show pause menu/UI
            Debug.Log("Game paused");
        }
        else
        {
            Time.timeScale = 1f; // Resume the game
            // Hide pause menu/UI
            Debug.Log("Game resumed");
        }
    }

    public void StartGame()
    {
        // Start the game by loading the next scene
        SceneManager.LoadScene("1");
    }

    public void ExitGame()
    {
        // Exit the game
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
