using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempSegMove : MonoBehaviour
{
    public float _SegmentForwardSpeed;

    void Update()
    {
        transform.position += new Vector3(0, 0, -_SegmentForwardSpeed * Time.deltaTime);
    }
}
