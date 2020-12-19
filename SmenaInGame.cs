using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmenaInGame : MonoBehaviour
{
    public Animator[] objectis;
    public Animator PauseMenu;
    public Animator Starka;
    public Animator Options;
    public Animator rotatkemenka;

    public WonIf aga;
    
    public GameObject PauseMenuBar;
    public GameObject[] pauseBTn;
    public GameObject MenuPauseInPauseMenu;
    public GameObject OptionBar;
   

    public void Start()
    {
        Invoke("Ofnut",0.7f);
    }

    public void Update()
    {
        if (aga.cubs <= 0) 
        {
            for (int i = 0; i < objectis.Length; i++)
            {
                objectis[i].SetInteger("Lvlanka", 2);
                Starka.SetInteger("Clics", 1);
                rotatkemenka.SetInteger("Triangles", 1);
            }
        }

        if (aga.desathCubes < aga.limit) 
        {
            for (int i = 0; i < objectis.Length; i++)
            {
                objectis[i].SetInteger("Lvlanka", 2);
                Starka.SetInteger("Clics", 1);
                rotatkemenka.SetInteger("Triangles", 1);
            }
        }

    }

    public void Ofnut() 
    {
            for (int i = 0; i < objectis.Length; i++)
            {
                objectis[i].SetInteger("Lvlanka", 1);
            }
    }
    public void Repolay() 
    {

    }

    public void OpenPauseMenu() 
    {
        for (int i = 0; i < objectis.Length; i++)
        {
            objectis[i].SetInteger("Lvlanka", 2);
            Starka.SetInteger("Clics", 1);
            rotatkemenka.SetInteger("Triangles", 1);
        }
        Invoke("openka",1.3f);
    }

    private void openka() 
    {
        for (int i = 0; i < pauseBTn.Length; i++)
        {
            pauseBTn[i].SetActive(false);
        }
        PauseMenuBar.SetActive(true);
    }

    public void ClosePauseMenu() 
    {
        PauseMenu.SetInteger("Mne",1);
        Invoke("TurnOffMenu",1);
    }

    private void TurnOffMenu() 
    {
        for (int i = 0; i < objectis.Length; i++)
        {
           
            objectis[i].SetInteger("Lvlanka", 0);
            Starka.SetInteger("Clics", 0);
        }
        for (int i = 0; i < pauseBTn.Length; i++)
        {
            pauseBTn[i].SetActive(true) ;
        }
        rotatkemenka.SetInteger("Triangles", 0);
        PauseMenuBar.SetActive(false);
    }

    public void OpenOptionsBar() 
    {
        PauseMenu.SetInteger("Mne",1);
        Invoke("Opkaten",1);
    }

    private void Opkaten() 
    {
        OptionBar.SetActive(true);
        MenuPauseInPauseMenu.SetActive(false);
    }

    public void CloseOptions() 
    {
        Options.SetInteger("closeOptions",1);
        Invoke("closkai",1);
    }

    private void closkai() 
    {
        OptionBar.SetActive(false);
        MenuPauseInPauseMenu.SetActive(true);
        PauseMenu.SetInteger("Mne", 0);
    }
}
