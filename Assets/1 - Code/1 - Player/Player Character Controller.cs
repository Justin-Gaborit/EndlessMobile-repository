using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    public Rigidbody _PlayerRigidbody;              //gives the player a rigidbody

    public float _PlayerGravity;                    //downward force applied to the player   
    public float _PlayerForwardSpeed;               //forward speed applied to the player
    public float _PlayerHorizontalSpeed;            //horizontal movement speed applied to the player
    public float _PlayerHorizontalSpeedMaximum;     //maximum horizontal speed the player can move at
    public float _PlayerJumpForce;                  //upward force applied to the player 

    public bool _PlayerisGrounded;                  //returns if the player is on the ground
    public bool _PlayerJumpHeightMet;               //returns if the player has reached maximum jump height
    public bool _PlayerisJumping;                   //returns if the player is in the air

    // Start is called before the first frame update
    void Start()
    {
        _PlayerRigidbody = GetComponent<Rigidbody>();           //assigns players rigidbody to "_PlayerRigidbody" variable
        _PlayerisGrounded = true;                               //player is grounded by default
        _PlayerJumpHeightMet = false;                           //player has not met maximum jumpheight by default
        _PlayerHorizontalSpeedMaximum = _PlayerHorizontalSpeed; //this is done to limit maximum horizontal travel speed
        _PlayerisJumping = false;                               //player is not jumping by default
        _PlayerForwardSpeed = 0;                                //THIS DEFINES THE SPEED THE PLAYER MOVES AT
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
