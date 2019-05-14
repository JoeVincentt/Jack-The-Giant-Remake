using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

      public void StartGame()
      {
            GameManager.instance.gameStartedFromMainMenu = true;
            SceneManager.LoadScene("Gameplay");
      }
      public void GoToHighScore()
      {
            SceneManager.LoadScene("High Score");
      }
      public void GoToOptions()
      {
            SceneManager.LoadScene("Options");
      }
      public void MusicButton()
      {
            //Music button logic
      }
      public void QuitGame()
      {
            Application.Quit();
      }









}
