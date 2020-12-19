using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsEarnOnCube : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stars")
        {
            Invoke("Pluskay",0.1f);
        }
    }

    public void Pluskay() 
    {
        StarEarn.Stars += 1;
    }
}
