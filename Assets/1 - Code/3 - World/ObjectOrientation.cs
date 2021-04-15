using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientation : MonoBehaviour
{
    void Start()
    {
         int _RandomRotationValue = Random.Range(0,360);
         transform.Rotate(0, 0, _RandomRotationValue);
    }
}
