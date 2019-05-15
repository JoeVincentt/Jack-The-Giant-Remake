using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
      [SerializeField] private Button musicButton;
      [SerializeField] private Sprite[] musicIcons;


      private void Start()
      {
            CheckToPlayMusic();
      }

      private void CheckToPlayMusic()
      {
            if (GamePreferences.GetIsMusicOn() == 1)
            {
                  MusicController.instance.PlayMusic(true);
                  musicButton.image.sprite = musicIcons[1];
            }
            else
            {
                  MusicController.instance.PlayMusic(false);
                  musicButton.image.sprite = musicIcons[0];
            }
      }
      public void StartGame()
      {
            GameManager.instance.gameStartedFromMainMenu = true;
            // SceneManager.LoadScene("Gameplay");
            SceneFader.instance.LoadLevel("Gameplay");
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
            if (GamePreferences.GetIsMusicOn() == 0)
            {
                  GamePreferences.SetIsMusicOn(1);
                  MusicController.instance.PlayMusic(true);
                  musicButton.image.sprite = musicIcons[1];
            }
            else if (GamePreferences.GetIsMusicOn() == 1)
            {
                  GamePreferences.SetIsMusicOn(0);
                  MusicController.instance.PlayMusic(false);
                  musicButton.image.sprite = musicIcons[0];
            }
      }
      public void QuitGame()
      {
            Application.Quit();
      }









}
