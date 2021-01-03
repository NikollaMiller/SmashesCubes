using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smenka : MonoBehaviour
{
    public GameObject[] panelki;
    public GameObject[] afterchetotam;
    public GameObject panelkii;
    public GameObject barier;

    public void ClicktoSmena1()
    {
        panelki[0].SetActive(false);
        panelki[1].SetActive(true);
    }
    public void ClicktoSmena2()
    {
        panelki[1].SetActive(false);
        panelki[2].SetActive(true);
    }

    public void ClicktoSmena3()
    {
        panelki[2].SetActive(false);
        panelki[3].SetActive(true);
    }

    public void ClicktoSmena4()
    {
        panelki[3].SetActive(false);
        panelki[4].SetActive(true);
    }

    public void ClicktoSmena5()
    {
        panelki[4].SetActive(false);
        panelki[5].SetActive(true);
    }

    public void ClicktoSmena6()
    {
        panelki[5].SetActive(false);
        panelki[6].SetActive(true);
    }

    public void ClicktoSmena7()
    {
        panelki[6].SetActive(false);
        afterchetotam[0].SetActive(true);
    }

    public void AfterChoose()
    {
        afterchetotam[0].SetActive(false);
        panelkii.SetActive(false);
        afterchetotam[1].SetActive(true);
    }

    public void AfterPlaced() 
    {
        afterchetotam[1].SetActive(false);
        afterchetotam[2].SetActive(true);
    }
    public void AfterDelBTn() 
    {
        afterchetotam[2].SetActive(false);
        barier.SetActive(false);
    }
}
