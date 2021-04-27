using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float jumpSpeed = 5f;
    public float gravity = 10f;
    public float ballSpeed = 5f;
    private Vector3 ballMovement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            ballMovement = new Vector3(0, 0, ySpeed);
            ballMovement = transform.TransformDirection(ballMovement);
            ballMovement *= ballSpeed;

            if(Input.GetButton("Jump"))
            {
                ballMovement.y = jumpSpeed;
            }
  
        }
        ballMovement.y -= gravity * Time.deltaTime;

        controller.Move(ballMovement * Time.deltaTime);

        transform.Rotate(0, xSpeed, 0);


    }
}
