﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
      [SerializeField]
      private AudioClip coinSound, lifeSound;
      private CameraScript cameraScript;
      private Vector3 previousPosition;
      private bool countScore;

      public static int scoreCount;
      public static int lifeCount;
      public static int coinCount;


      private void Awake()
      {
            cameraScript = Camera.main.GetComponent<CameraScript>();
      }

      void Start()
      {
            previousPosition = transform.position;
            countScore = true;
      }



      void Update()
      {
            CountScore();
      }
      private void CountScore()
      {
            if (countScore)
            {
                  if (transform.position.y < previousPosition.y)
                  {
                        scoreCount++;
                        GameplayController.instance.SetScoreCount(scoreCount);
                  }
                  previousPosition = transform.position;
            }
      }

      private void OnTriggerEnter2D(Collider2D target)
      {
            if (target.tag == "Coin")
            {
                  coinCount++;
                  scoreCount += 200;

                  GameplayController.instance.SetScoreCount(scoreCount);
                  GameplayController.instance.SetCoinCount(coinCount);

                  AudioSource.PlayClipAtPoint(coinSound, transform.position);

                  target.gameObject.SetActive(false);
            }

            if (target.tag == "Life")
            {
                  lifeCount++;
                  scoreCount += 300;

                  GameplayController.instance.SetScoreCount(scoreCount);
                  GameplayController.instance.SetLifeCount(lifeCount);

                  AudioSource.PlayClipAtPoint(lifeSound, transform.position);

                  target.gameObject.SetActive(false);
            }

            if (target.tag == "Bounds")
            {
                  cameraScript.moveCamera = false;
                  countScore = false;

                  transform.position = new Vector3(500, 500, 0);
                  lifeCount--;
                  GameManager.instance.CheckGameStatus(scoreCount, coinCount, lifeCount);
            }

            if (target.tag == "Deadly Cloud")
            {
                  cameraScript.moveCamera = false;
                  countScore = false;


                  transform.position = new Vector3(500, 500, 0);
                  lifeCount--;
                  GameManager.instance.CheckGameStatus(scoreCount, coinCount, lifeCount);
            }
      }

}
