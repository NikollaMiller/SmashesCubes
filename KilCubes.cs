using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilCubes : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Whus") 
        {
            Destroy(other.gameObject);
        }
    }
}
