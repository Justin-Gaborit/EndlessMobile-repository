using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segmentcontroller : MonoBehaviour
{
    public GameObject director;
    public float _SegmentForwardSpeed;

    private void Start()
    {
        director = GameObject.Find("game manager");
    }

    void Update()
    {
        _SegmentForwardSpeed = director.GetComponent<director>().runspeed;
        transform.position += new Vector3(0, 0, -_SegmentForwardSpeed * Time.deltaTime);
    }
}
