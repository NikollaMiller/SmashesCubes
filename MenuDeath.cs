using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDeath : MonoBehaviour
{
    public GameObject Win;
    public int cube;

    public void Update()
    {
        if (cube <=0) 
        {
            Win.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CUBS") 
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "CubsTut")
        {
            cube -= 1;
            Destroy(other.gameObject);
        }
    }
}
