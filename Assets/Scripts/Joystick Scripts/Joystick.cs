using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
      private PlayerMoveJoystick playerMove;

      private void Start()
      {
            playerMove = GameObject.Find("Player").GetComponent<PlayerMoveJoystick>();
      }
      public void OnPointerUp(PointerEventData data)
      {
            if (gameObject.name == "Left")
            {
                  playerMove.SetMoveLeft(true);
            }
            else
            {
                  playerMove.SetMoveLeft(false);
            }
      }
      public void OnPointerDown(PointerEventData data)
      {
            playerMove.StopMoving();
      }
}
