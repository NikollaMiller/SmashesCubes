using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosseWall : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cubs") 
        {
            Destroy(other.gameObject);
        }

    }
}
