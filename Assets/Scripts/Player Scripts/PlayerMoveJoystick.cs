using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveJoystick : MonoBehaviour
{
      [SerializeField] float speed = 8f, maxVelocity = 4f;
      Rigidbody2D myRigidBody2D;
      Animator myAnimator;
      private bool moveLeft, moveRight;

      private void Awake()
      {
            myRigidBody2D = GetComponent<Rigidbody2D>();
            myAnimator = GetComponent<Animator>();
      }

      private void FixedUpdate()
      {
            if (moveLeft)
            {
                  MoveLeft();
            }
            if (moveRight)
            {
                  MoveRight();
            }
      }

      public void SetMoveLeft(bool moveLeft)
      {
            this.moveLeft = moveLeft;
            this.moveRight = !moveLeft;
      }

      public void StopMoving()
      {
            moveLeft = false;
            moveRight = false;
            myAnimator.SetBool("Walking", false);
      }
      private void MoveLeft()
      {
            float forceX = 0f;
            float velocity = Mathf.Abs(myRigidBody2D.velocity.x);
            if (velocity < maxVelocity)
            {
                  forceX = -speed;
                  myAnimator.SetBool("Walking", true);
                  //Make it face the right direction
                  Vector3 temp = transform.localScale;
                  temp.x = -1.3f;
                  transform.localScale = temp;
            }
            myRigidBody2D.AddForce(new Vector2(forceX, 0));
      }
      private void MoveRight()
      {
            float forceX = 0f;
            float velocity = Mathf.Abs(myRigidBody2D.velocity.x);
            if (velocity < maxVelocity)
            {
                  forceX = speed;
                  myAnimator.SetBool("Walking", true);
                  //Make it face the right direction
                  Vector3 temp = transform.localScale;
                  temp.x = 1.3f;
                  transform.localScale = temp;
            }
            myRigidBody2D.AddForce(new Vector2(forceX, 0));
      }














}
