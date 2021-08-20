using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator PlayerAnims;

    public float speed = 12f;
    private float gravity = 14f;
    private float verticalVelocity;
    private bool isMoving = false;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        isMoving = !(x == 0f && z == 0f);

        //Trigger running animation if any movement input is recieved
        PlayerAnims.SetBool("isMoving", isMoving);

        //If there is input, update the player position and rotation
        if (isMoving)
        {
            Vector3 move = transform.right * x + transform.forward * z;
            Quaternion rotation = Quaternion.LookRotation(move, Vector3.up);

            controller.Move(move * speed * Time.deltaTime);

            //TODO : The player must be at index 0, this is a crap dependency and should be fixed
            transform.GetChild(0).rotation = rotation;
        }

        if(controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
    }
}
