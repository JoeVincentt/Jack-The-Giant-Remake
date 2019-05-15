using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HighScoreController : MonoBehaviour
{
      [SerializeField] private TextMeshProUGUI scoreText, coinText;

      private void Start()
      {
            SetScoreBasedOnDifficulty();
      }

      private void SetScore(int score, int coinCount)
      {
            scoreText.text = score.ToString();
            coinText.text = coinCount.ToString();
      }

      private void SetScoreBasedOnDifficulty()
      {
            if (GamePreferences.GetEasyDifficulty() == 1)
            {
                  SetScore(GamePreferences.GetEasyDifficultyHighScore(), GamePreferences.GetEasyDifficultyCoins());
            }
            if (GamePreferences.GetMediumDifficulty() == 1)
            {
                  SetScore(GamePreferences.GetMediumDifficultyHighScore(), GamePreferences.GetMediumDifficultyCoins());
            }
            if (GamePreferences.GetHardDifficulty() == 1)
            {
                  SetScore(GamePreferences.GetHardDifficultyHighScore(), GamePreferences.GetHardDifficultyCoins());
            }
      }
      public void GoBackToMainMenu()
      {
            SceneManager.LoadScene("Main Menu");
      }






}
