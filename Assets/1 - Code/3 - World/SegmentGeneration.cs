using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGeneration : MonoBehaviour
{
    public GameObject[] _SegmentArray;

    private void OnTriggerEnter(Collider collision)
    {
        Vector3 SpawnLocation = new Vector3();
        SpawnLocation = GameObject.Find("Segment_Spawn").transform.position;

        if (collision.gameObject.tag == "Player")
        {
            int RandomInt = Random.Range(0, 2);
            Instantiate(_SegmentArray[RandomInt], SpawnLocation, Quaternion.identity);
            Destroy(GameObject.Find("Segment_Spawn"));
            Debug.Log("Collided and Cell Generated");
            Destroy(gameObject);
        }
    }
}



