using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
