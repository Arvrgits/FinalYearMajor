using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuController : MonoBehaviour
{
    // Reference to the XR Grab Interactable component
    public XRGrabInteractable grabInteractable;

    void Start()
    {
        // Add an event listener for the button press
        grabInteractable.onSelectEntered.AddListener(StartGame);
    }

    void StartGame(XRBaseInteractor interactor)
    {
        // Add your start game logic here
        Debug.Log("Game started!");
    }
}

