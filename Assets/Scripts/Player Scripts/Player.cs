using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
      [SerializeField] float speed = 8f, maxVelocity = 4f;
      Rigidbody2D myRigidBody2D;
      Animator myAnimator;

      private void Awake()
      {
            myRigidBody2D = GetComponent<Rigidbody2D>();
            myAnimator = GetComponent<Animator>();
      }
      void Start()
      {

      }

      void FixedUpdate()
      {
            PlayerMoveKeyBoard();
      }

      private void PlayerMoveKeyBoard()
      {
            float forceX = 0f;
            float velocity = Mathf.Abs(myRigidBody2D.velocity.x);

            float playerMoveHorizontal = Input.GetAxisRaw("Horizontal");

            if (playerMoveHorizontal > 0)
            {
                  if (velocity < maxVelocity)
                  {
                        forceX = speed;
                        myAnimator.SetBool("Walking", true);
                        //Make it face the right direction
                        Vector3 temp = transform.localScale;
                        temp.x = 1.3f;
                        transform.localScale = temp;
                  }

            }
            else if (playerMoveHorizontal < 0)

            {
                  if (velocity < maxVelocity)
                  {
                        forceX = -speed;
                        myAnimator.SetBool("Walking", true);
                        //Make it face the right direction
                        Vector3 temp = transform.localScale;
                        temp.x = -1.3f;
                        transform.localScale = temp;
                  }
            }
            else
            {
                  myAnimator.SetBool("Walking", false);
            }

            myRigidBody2D.AddForce(new Vector2(forceX, 0));

      }








}
