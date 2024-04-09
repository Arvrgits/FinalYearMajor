using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit_button : MonoBehaviour
{
    public GameObject quit;
    private Button quitButton;

    private void Start()
    {
        quitButton = quit.GetComponent <Button>();
    }

    private void Update()
    {
        if((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && Input.GetKeyDown(KeyCode.Q))
        { 
        quitButton.onClick.Invoke();        }
    }

    public void QuitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
}
