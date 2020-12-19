using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameForLoadingScreen : MonoBehaviour
{
    public GameObject[] cbe;

    public InGameForLoadingScreen spukich;
    public static int tomenku;
    public Transform pos;
    public float Width;

    public void Start()
    {
            for (int i = 0; i < cbe.Length; i++)
            {
                var cell = Instantiate(cbe[i], pos);
                cell.transform.localPosition = new Vector3(Random.Range(0, Width), 0, 0);
            }
            Invoke("Offfall", .6f); 
    }

    void Update()
    {
        if (tomenku == 1)
        {
            for (int i = 0; i < cbe.Length; i++)
            {
                var cell = Instantiate(cbe[i], pos);
                cell.transform.localPosition = new Vector3(Random.Range(0, Width), 0, 0);
            }
        }

        for (int i = 0; i < cbe.Length; i++)
        {
            var cell = Instantiate(cbe[i], pos);
            cell.transform.localPosition = new Vector3(Random.Range(0, Width), 0, 0);
        }
    }

    public void Offfall()
    {
        spukich.enabled = false;
    }
}
