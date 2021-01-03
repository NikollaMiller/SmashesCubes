using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunusGameKillFallCubes : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Whus") 
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Stars")
        {
            Destroy(other.gameObject);
        }
    }
}
