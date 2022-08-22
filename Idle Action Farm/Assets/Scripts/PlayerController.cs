using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   public DynamicJoystick joystick;
    
    private float trSpeed = 10;
    private float rotSpeed = 100;
    private float horizontal, vertical;
    private Rigidbody _rigidbody;
    private Animator playerAnimations;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
        playerAnimations = GetComponent<Animator>();
        
    }

   
    void Update()
    {
        horizontal = joystick.Horizontal * rotSpeed * Time.deltaTime;
        vertical = joystick.Vertical * trSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
        transform.Translate(0, 0, vertical);
        if (joystick.Horizontal != 0 && joystick.Vertical != 0)
        {
            playerAnimations.SetTrigger("Run");
        }
        else
        { playerAnimations.SetTrigger("Run_b"); }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (joystick.Horizontal != 0 && joystick.Vertical != 0)
        {
            if (other.CompareTag("Garden"))
            {
                playerAnimations.SetTrigger("Mow");
            }
        }
        else
        {
            if (other.CompareTag("Garden"))
            {
                playerAnimations.SetTrigger("Mow");
            }
        }
    }
}