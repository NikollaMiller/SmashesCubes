using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public WonIf aga;
    public AudioSource bjih;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cubs") 
        {
            Destroy(other.gameObject);
            bjih.Play();
            aga.cubs --;
            Debug.Log(aga.cubs);
        }
    }
}
