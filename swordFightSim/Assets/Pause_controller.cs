using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;


public class Pause_controller : MonoBehaviour
{
    private bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        // Check if the Oculus Touch controller's "Menu" button is pressed
        if (OVRInput.GetDown(OVRInput.Button.Start) || OVRInput.GetDown(OVRInput.Button.Two))
        {
            TogglePause(); // Toggle pause state
        }
    }

    void TogglePause()
    {
        if (isPaused)
        {
            Resume(); // If game is paused, resume it
        }
        else
        {
            Pause(); // If game is not paused, pause it
        }
    }

    void Pause()
    {
        Time.timeScale = 0f; // Pause the game
        isPaused = true;
    }

    void Resume()
    {
        Time.timeScale = 1f; // Resume the game
        isPaused = false;
    }
}