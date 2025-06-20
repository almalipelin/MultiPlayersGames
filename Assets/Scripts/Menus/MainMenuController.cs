using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void PlayGame()
   {
       SceneManager.LoadScene("PlayerSelection");
   }
   
   public void OpenSettings()
   {
       SceneManager.LoadScene("Settings");    
   }

   public void QuitGame()
   {
       Debug.Log("Quitting Game...");
       Application.Quit();
   }

}
