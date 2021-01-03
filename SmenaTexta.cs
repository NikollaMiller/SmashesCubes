using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmenaTexta : MonoBehaviour
{
    public GameObject[] texta;
    public Animator RobotAnimka;
    public Animator BgbkPanel;
    public Animator[] Bk;
    public GameObject Blockpanel;
    public int da;

    public void Update()
    {
        if (da == 0)
        {
            texta[0].SetActive(true);
        }
        else if (da == 1)
        {
            texta[0].SetActive(false);
            texta[1].SetActive(true);
        }
        else if (da == 2)
        {
            texta[0].SetActive(false);
            texta[1].SetActive(false);
            texta[2].SetActive(true);
        }
        else if (da == 3)
        {
            texta[0].SetActive(false);
            texta[1].SetActive(false);
            texta[2].SetActive(false);
            texta[3].SetActive(true);
        }
        else if (da == 4)
        {
            texta[0].SetActive(false);
            texta[1].SetActive(false);
            texta[2].SetActive(false);
            texta[3].SetActive(false);
            texta[4].SetActive(true);
        }
        else if (da == 5)
        {
            texta[0].SetActive(false);
            texta[1].SetActive(false);
            texta[2].SetActive(false);
            texta[3].SetActive(false);
            texta[4].SetActive(true);
        }
        else if (da == 6) 
        {
            texta[0].SetActive(false);
            texta[4].SetActive(false);
            texta[5].SetActive(true);
            for (int i = 0; i < Bk.Length; i++)
            {
                Bk[i].SetInteger("nokl",1);
            }
            Blockpanel.SetActive(true);
            BgbkPanel.SetInteger("aga",1);
            RobotAnimka.SetInteger("robutka",1);
        }
    }

    public void ClickedToSmena() 
    {
        da++;
    }
}
