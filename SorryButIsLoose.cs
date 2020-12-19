using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorryButIsLoose : MonoBehaviour
{
    public WonIf ds;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cubs") 
        {
            ds.desathCubes --;
            Destroy(other.gameObject);
        }
    }
}
