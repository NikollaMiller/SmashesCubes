using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cbe;
    public Transform pos;
    public float Width;

    void Update()
    {
        for (int i = 0; i < cbe.Length; i++)
        {
            var cell =Instantiate(cbe[i],pos);
            cell.transform.localPosition = new Vector3(Random.Range(0,Width),0,0);
        }
    }
}
