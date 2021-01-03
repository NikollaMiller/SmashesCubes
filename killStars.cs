using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killStars : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Stars")
        {
            Destroy(other.gameObject);
        }
    }
}
