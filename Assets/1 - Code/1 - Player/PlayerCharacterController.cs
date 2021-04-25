using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{

    public float _PlayerHorizontalSpeed;            //horizontal movement speed applied to the player
    public float _PlayerHorizontalSpeedMaximum;     //maximum horizontal speed the player can move at

    public bool _PlayerMovingRight;
    public bool _PlayerMovingLeft;

    // Start is called before the first frame update
    void Start()
    {
        _PlayerMovingRight = false;
        _PlayerMovingLeft = false;
        _PlayerHorizontalSpeedMaximum = _PlayerHorizontalSpeed; //this is done to limit maximum horizontal travel speed                       
    }

    public void PointerRightDown() { _PlayerMovingRight = true; }
    public void PointerRightUp() { _PlayerMovingRight = false; }

    public void PointerLeftDown() { _PlayerMovingLeft = true; }
    public void PointerLefttUp() { _PlayerMovingLeft = false; }

    // Update is called once per frame
    void Update()
    {
        if (_PlayerMovingRight)
        {
            transform.Rotate(0, 0, -_PlayerHorizontalSpeed * Time.deltaTime);
        }

        if (_PlayerMovingLeft)
        {
            transform.Rotate(0, 0, _PlayerHorizontalSpeed * Time.deltaTime);
        }

        /*if (Input.GetKey("right"))
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

        if (Input.GetKey("space"))
        {
            _PlayerisGrounded = false;
            Invoke("SetBoolBack", 1);
        }*/
    }

    void FixedUpdate()
    {
    }
}
