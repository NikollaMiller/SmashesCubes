using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZvukStuk : MonoBehaviour
{
    public AudioSource stukich;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Walls")
        {
            stukich.Play();
        }

        if (other.gameObject.tag == "Platform")
        {
            stukich.Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        stukich.Stop();
    }
}
