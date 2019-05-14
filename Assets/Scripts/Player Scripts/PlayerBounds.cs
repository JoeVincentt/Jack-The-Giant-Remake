using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
      private float minX, maxX;



      void Start()
      {
            SetMinAndMaxX();
      }

      void Update()
      {
            KeepPlayerOnXaxis();
      }


      private void KeepPlayerOnXaxis()
      {
            if (transform.position.x < minX)
            {
                  Vector3 temp = transform.position;
                  temp.x = minX;
                  transform.position = temp;
            }
            if (transform.position.x > maxX)
            {
                  Vector3 temp = transform.position;
                  temp.x = maxX;
                  transform.position = temp;
            }
      }
      private void SetMinAndMaxX()
      {
            Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

            minX = -bounds.x;
            maxX = bounds.x;

      }
}
