using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadToMenu : MonoBehaviour
{    
    public GameObject panel;
    public static int falka;
    public Spawner spawn;
    public Slider SlideToLoad;

    public Text[] drugs;
    public Font[] aga;
    public void Update()
    {
        if (Application.systemLanguage == SystemLanguage.Russian) 
        {
            for (int i = 0; i < drugs.Length; i++)
            {
                drugs[i].text = "Перетащите вправо";
                drugs[i].font = aga[0];
            }
        }
        if (Application.systemLanguage == SystemLanguage.English)
        {
            for (int i = 0; i < drugs.Length; i++)
            {
                drugs[i].text = "DRAG TO RIGHT";
                drugs[i].font = aga[1];
            }
        }
        if (Application.systemLanguage == SystemLanguage.Korean)
        {
            for (int i = 0; i < drugs.Length; i++)
            {
                drugs[i].text = "오른쪽으로 드래그";
                drugs[i].font = aga[1];
            }
        }
        if (SlideToLoad.value >= 1) 
        {
            panel.SetActive(true);
            spawn.enabled = true;
            falka = 1;
            Invoke("ToMenu",1.7f);
        }
    }

    public void ToMenu() 
    {
        SceneManager.LoadScene("Menu");
    }
}
