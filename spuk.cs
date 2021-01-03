using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spuk : MonoBehaviour
{
    public GameObject[] cbe;

    public spuk spukich;
    public Transform pos;
    public float Width;

    public void Start()
    {
        Invoke("Offfall", .6f);
    }

    void Update()
    {

        for (int i = 0; i < cbe.Length; i++)
        {
            var cell = Instantiate(cbe[i], pos);
            cell.transform.localPosition = new Vector3(Random.Range(0, Width), 0, 0);
        }
    }

    private void Offfall() 
    {
        spukich.enabled = false;
    }
}
