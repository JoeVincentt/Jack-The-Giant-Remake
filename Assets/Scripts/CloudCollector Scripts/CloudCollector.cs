using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollector : MonoBehaviour
{
      private void OnTriggerEnter2D(Collider2D targetCollider)
      {
            if (targetCollider.tag == "Cloud" || targetCollider.tag == "Deadly Cloud")
            {
                  targetCollider.gameObject.SetActive(false);
            }
      }
}
