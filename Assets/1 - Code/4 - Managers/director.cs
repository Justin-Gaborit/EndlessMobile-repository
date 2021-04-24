using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class director : MonoBehaviour
{
    public GameObject playerobject;
    public GameObject terrain;
    public GameObject playercamera;
    public GameObject startbutton;
    public GameObject settingsbutton;
    public TextMeshProUGUI galactatext;
    public TextMeshProUGUI runnertext;

    public Animator camera_animation_manager;
    public Animator startbutton_animation_manager;
    public Animator settingsbutton_animation_manager;
    public Animator galactatext_animation_manager;
    public Animator runnertext_animation_manager;

    public int runspeed = 0;

    public void GameStart()
    {
        runspeed = 20;
        camera_animation_manager.SetBool("game start", true);
        startbutton_animation_manager.SetBool("game start", true);
        settingsbutton_animation_manager.SetBool("game start", true);
        galactatext_animation_manager.SetBool("game start", true);
        runnertext_animation_manager.SetBool("game start", true);
    }

    void Start()
    {
        camera_animation_manager = playercamera.GetComponent<Animator>();
        startbutton_animation_manager = startbutton.GetComponent<Animator>();
        settingsbutton_animation_manager = settingsbutton.GetComponent<Animator>();
        galactatext_animation_manager = galactatext.GetComponent<Animator>();
        runnertext_animation_manager = runnertext.GetComponent<Animator>();
    }


    void Update()
    {
        
    }
}
