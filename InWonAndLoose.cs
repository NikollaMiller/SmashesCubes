using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InWonAndLoose : MonoBehaviour
{
    public Animator Wonka;
    public Animator Replay;
    public Animator loose;
    public Animator[] starki;

    public InGameForLoadingScreen spawn;

    public void ClickToResp()
    {
        for (int i = 0; i < starki.Length; i++)
        {
            starki[i].SetInteger("zvedki",2);
        }
        Wonka.SetInteger("wonka", 1);
        Invoke("Spawnblocks",0.7f);
        Invoke("Resppod",1.8f);
    }

    public void NextButton() 
    {
        for (int i = 0; i < starki.Length; i++)
        {
            starki[i].SetInteger("zvedki", 2);
        }
        Wonka.SetInteger("wonka", 1);
        Invoke("Spawnblocks", 0.7f);
    }

    public void Spawnblocks() 
    {
        spawn.enabled = true;
    }

    private void Resppod()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void ClickToMEnu() 
    {
        for (int i = 0; i < starki.Length; i++)
        {
            starki[i].SetInteger("zvedki", 2);
        }
        Wonka.SetInteger("wonka", 1);
        Invoke("Spawnblocks", 0.7f);
        Invoke("Menka", 1.8f);
    }

    private void Menka()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RespawnInloose() 
    {
        loose.SetInteger("Closs",1);
        Invoke("Spawnblocks", 0.7f);
        Invoke("forrespawn", 1.8f);
    }

    private void forrespawn() 
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void MenuinLoose() 
    {
        loose.SetInteger("Closs", 1);
        Invoke("Spawnblocks", 0.7f);
        Invoke("formenuloose", 1.8f);
    }

    private void formenuloose() 
    {
        SceneManager.LoadScene("Menu");
    }


    public void ReplayMenuAnimat() 
    {
        for (int i = 0; i < starki.Length; i++)
        {
            starki[i].SetInteger("zvedki", 2);
        }
        Replay.SetInteger("Replika",1);
        Invoke("Spawnblocks", 0.7f);
        Invoke("forrespawn",1.5f);
    }

    public void ReplayMenu() 
    {
        for (int i = 0; i < starki.Length; i++)
        {
            starki[i].SetInteger("zvedki", 2);
        }
        Invoke("formenuloose",1.5f);
        Replay.SetInteger("Replika", 1);
        Invoke("Spawnblocks", 0.7f);
    }
}
