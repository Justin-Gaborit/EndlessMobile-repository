using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{   
    public float _PlayerForwardSpeed;               //forward speed applied to the player
    public float _PlayerHorizontalSpeed;            //horizontal movement speed applied to the player
    public float _PlayerHorizontalSpeedMaximum;     //maximum horizontal speed the player can move at

    public bool _PlayerisGrounded;                  //returns if the player is on the ground
    public bool _PlayerisJumping;                   //returns if the player is in the air

    // Start is called before the first frame update
    void Start()
    {

        _PlayerisGrounded = true;                               //player is grounded by default
        _PlayerHorizontalSpeedMaximum = _PlayerHorizontalSpeed; //this is done to limit maximum horizontal travel speed
        _PlayerisJumping = false;                               //player is not jumping by default                               
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0, -_PlayerHorizontalSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, _PlayerHorizontalSpeed * Time.deltaTime);
        }
        else 
        {
            transform.Rotate(0, 0, 0);
        }

        transform.position += new Vector3(0,0, _PlayerForwardSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
    }
}
