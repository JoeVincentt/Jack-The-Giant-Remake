using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
      public static GameManager instance;
      [HideInInspector] public bool gameStartedFromMainMenu, gameRestartedAfterDeath;
      [HideInInspector] public int score, coinCount, lifeCount;

      private void Awake()
      {
            MakeSingleton();
      }

      //   private void OnEnable()
      //   {
      //         SceneManager.sceneLoaded += OnLevelWasLoaded;
      //   }
      //   private void OnDisable()
      //   {
      //         SceneManager.sceneLoaded -= OnLevelWasLoaded;
      //   }

      private void OnLevelWasLoaded()
      {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "Gameplay")
            {
                  if (gameRestartedAfterDeath)
                  {
                        GameplayController.instance.SetScoreCount(score);
                        GameplayController.instance.SetLifeCount(lifeCount);
                        GameplayController.instance.SetCoinCount(coinCount);

                        PlayerScore.scoreCount = score;
                        PlayerScore.coinCount = coinCount;
                        PlayerScore.lifeCount = lifeCount;
                  }
                  else if (gameStartedFromMainMenu)
                  {
                        PlayerScore.scoreCount = 0;
                        PlayerScore.coinCount = 0;
                        PlayerScore.lifeCount = 2;

                        GameplayController.instance.SetScoreCount(0);
                        GameplayController.instance.SetCoinCount(0);
                        GameplayController.instance.SetLifeCount(2);
                  }
            }

      }

      private void MakeSingleton()
      {
            if (instance != null)
            {
                  Destroy(gameObject);
            }
            else
            {
                  instance = this;
                  DontDestroyOnLoad(gameObject);
            }

      }


      public void CheckGameStatus(int score, int coinCount, int lifeCount)
      {
            if (lifeCount < 0)
            {
                  gameStartedFromMainMenu = false;
                  gameRestartedAfterDeath = false;

                  GameplayController.instance.GameOverShowPanel(score, coinCount);
            }
            else
            {
                  this.score = score;
                  this.coinCount = coinCount;
                  this.lifeCount = lifeCount;

                  GameplayController.instance.SetScoreCount(score);
                  GameplayController.instance.SetCoinCount(coinCount);
                  GameplayController.instance.SetLifeCount(lifeCount);

                  gameStartedFromMainMenu = false;
                  gameRestartedAfterDeath = true;

                  GameplayController.instance.PlayerDiedRestartGame();
            }
      }
}
