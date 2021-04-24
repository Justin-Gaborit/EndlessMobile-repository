using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterAnimationHandler : MonoBehaviour
{
    public GameObject PlayerParent;
    public GameObject Player;
    public Animator PlayerAnimator;


    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        if (PlayerParent.GetComponent<PlayerCharacterController>()._PlayerisGrounded == false)
        {
            PlayerAnimator.SetInteger("Condition_Jump", 1);
        }

        if (PlayerParent.GetComponent<PlayerCharacterController>()._PlayerisGrounded == true)
        {
           PlayerAnimator.SetInteger("Condition_Jump", 0);
        }
    }
}
