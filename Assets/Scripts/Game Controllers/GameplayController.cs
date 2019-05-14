using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameplayController : MonoBehaviour
{
      public static GameplayController instance;
      [SerializeField] private TextMeshProUGUI scoreText, coinText, lifeText, gameOverScoreText, gameOverCoinText;
      [SerializeField] private GameObject pausePanel;
      [SerializeField] private GameObject gameOverPanel;
      [SerializeField] private GameObject readyButton;
      private void Awake()
      {
            MakeInstance();
      }
      private void Start()
      {
            Time.timeScale = 0f;
      }
      public void GameOverShowPanel(int finalScore, int finalCoinCount)
      {
            gameOverPanel.SetActive(true);
            gameOverCoinText.text = finalCoinCount.ToString();
            gameOverScoreText.text = finalScore.ToString();
            StartCoroutine(GameOverLoadMainMenu());
      }

      IEnumerator GameOverLoadMainMenu()
      {
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Main Menu");
      }

      public void PlayerDiedRestartGame()
      {
            StartCoroutine(PlayerDiedRestart());
      }
      IEnumerator PlayerDiedRestart()
      {
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene("Gameplay");
      }
      public void SetScoreCount(int score)
      {
            scoreText.text = "x" + score;
      }
      public void SetCoinCount(int coinCount)
      {
            coinText.text = "x" + coinCount;
      }
      public void SetLifeCount(int lifeCount)
      {
            lifeText.text = "x" + lifeCount;
      }
      private void MakeInstance()
      {
            if (instance == null)
            {
                  instance = this;
            }
      }

      public void PauseTheGame()
      {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
      }

      public void ResumeGame()
      {
            Time.timeScale = 1f;
            pausePanel.SetActive(false);
      }

      public void QuitGame()
      {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Main Menu");
      }

      public void ReadyToStartGame()
      {
            Time.timeScale = 1f;
            readyButton.SetActive(false);
      }




}
