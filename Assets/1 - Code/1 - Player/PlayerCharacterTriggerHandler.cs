using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCharacterTriggerHandler : MonoBehaviour
{
    public int distancescore = 0;

    public TextMeshProUGUI scoretext;

    void OnTriggerEnter(Collider colides)
    {
        if (colides.gameObject.tag == "DistanceTrigger")
        {
            distancescore += 1;
            Destroy(colides.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = (distancescore.ToString());
    }
}
