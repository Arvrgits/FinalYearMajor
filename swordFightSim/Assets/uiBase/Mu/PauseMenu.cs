using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject MenuPause;

   public void Pause()
   {
    MenuPause.SetActive(true);
   }

   public void Home()
   {
    SceneManager.LoadScene("Main Menu");
       }

public void Resume()
{
    MenuPause.SetActive(false);
}

public void Restart()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
 }
