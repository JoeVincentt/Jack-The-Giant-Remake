using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
      void Start()
      {
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            Vector3 tempScale = transform.localScale;

            float spriteWidth = sr.sprite.bounds.size.x;

            float worldHeight = Camera.main.orthographicSize * 2f;
            float worldWidth = worldHeight / Screen.height * Screen.width;

            tempScale.x = worldWidth / spriteWidth;
            transform.localScale = tempScale;





      }


}
