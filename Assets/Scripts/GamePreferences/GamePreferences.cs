using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePreferences
{

      //difficulty lvl
      public static string EasyDifficulty = "EasyDifficulty";
      public static string MediumDifficulty = "MediumDifficulty";
      public static string HardDifficulty = "HardDifficulty";

      //score on difficulty lvl
      public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
      public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
      public static string HardDifficultyHighScore = "HardDifficultyHighScore";

      //coins on difficulty lvl
      public static string EasyDifficultyCoins = "EasyDifficultyCoins";
      public static string MediumDifficultyCoins = "MediumDifficultyCoins";
      public static string HardDifficultyCoins = "HardDifficultyCoins";

      //music preferences
      public static string IsMusicOn = "IsMusicOn";


      //NOTE int represent boolean values
      // 0 - false, 1 - true

      //music switch
      public static void SetIsMusicOn(int musicOn)
      {
            PlayerPrefs.SetInt(GamePreferences.IsMusicOn, musicOn);
      }
      public static int GetIsMusicOn()
      {
            return PlayerPrefs.GetInt(GamePreferences.IsMusicOn);
      }


      //easy getters and setters
      public static void SetEasyDifficulty(int difficulty)
      {
            PlayerPrefs.SetInt(GamePreferences.EasyDifficulty, difficulty);
      }
      public static int GetEasyDifficulty()
      {
            return PlayerPrefs.GetInt(GamePreferences.EasyDifficulty);
      }
      public static void SetEasyDifficultyHighScore(int highScore)
      {
            PlayerPrefs.SetInt(GamePreferences.EasyDifficultyHighScore, highScore);
      }
      public static int GetEasyDifficultyHighScore()
      {
            return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyHighScore);
      }
      public static void SetEasyDifficultyCoins(int coins)
      {
            PlayerPrefs.SetInt(GamePreferences.EasyDifficultyCoins, coins);
      }
      public static int GetEasyDifficultyCoins()
      {
            return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyCoins);
      }


      //medium getters and setters
      public static void SetMediumDifficulty(int difficulty)
      {
            PlayerPrefs.SetInt(GamePreferences.MediumDifficulty, difficulty);
      }
      public static int GetMediumDifficulty()
      {
            return PlayerPrefs.GetInt(GamePreferences.MediumDifficulty);
      }
      public static void SetMediumDifficultyHighScore(int highScore)
      {
            PlayerPrefs.SetInt(GamePreferences.MediumDifficultyHighScore, highScore);
      }
      public static int GetMediumDifficultyHighScore()
      {
            return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyHighScore);
      }
      public static void SetMediumDifficultyCoins(int coins)
      {
            PlayerPrefs.SetInt(GamePreferences.MediumDifficultyCoins, coins);
      }
      public static int GetMediumDifficultyCoins()
      {
            return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyCoins);
      }

      //hard getters and setters
      public static void SetHardDifficulty(int difficulty)
      {
            PlayerPrefs.SetInt(GamePreferences.HardDifficulty, difficulty);
      }
      public static int GetHardDifficulty()
      {
            return PlayerPrefs.GetInt(GamePreferences.HardDifficulty);
      }
      public static void SetHardDifficultyHighScore(int highScore)
      {
            PlayerPrefs.SetInt(GamePreferences.HardDifficultyHighScore, highScore);
      }
      public static int GetHardDifficultyHighScore()
      {
            return PlayerPrefs.GetInt(GamePreferences.HardDifficultyHighScore);
      }
      public static void SetHardDifficultyCoins(int coins)
      {
            PlayerPrefs.SetInt(GamePreferences.HardDifficultyCoins, coins);
      }
      public static int GetHardDifficultyCoins()
      {
            return PlayerPrefs.GetInt(GamePreferences.HardDifficultyCoins);
      }







}
