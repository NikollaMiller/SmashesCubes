using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffOnCubesFall : MonoBehaviour
{
    public GameObject spawner;
    public Slider slide;
    void Start()
    {
        slide.value = PlayerPrefs.GetFloat("save", slide.value);
    }

 
    void Update()
    {
        if (slide.value == 1)
        {
            spawner.GetComponent<Spawner>().enabled = !spawner.GetComponent<Spawner>().enabled;
        }
        PlayerPrefs.GetFloat("save", slide.value);
    }
}
