using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrientationController : MonoBehaviour
{
    public GameObject PlayerObject;
    public float PlayerRotationSpeed;
    Vector3 PlayerObjectCenter;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRotationSpeed = PlayerRotationSpeed + Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit PlayerOBJRaycastHitInfo;

        Physics.Raycast(transform.position, -transform.up, out PlayerOBJRaycastHitInfo, Mathf.Infinity);
        Debug.DrawRay(transform.position, -transform.up * Mathf.Infinity, Color.red);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, PlayerOBJRaycastHitInfo.transform.localRotation, PlayerRotationSpeed);
    }
}
