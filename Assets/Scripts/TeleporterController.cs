using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterController : MonoBehaviour
{
    public Transform[] locations;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int index = Random.Range(0, locations.Length);
            other.gameObject.transform.position = locations[index].position;
            Physics.SyncTransforms();
        }
    }
}
