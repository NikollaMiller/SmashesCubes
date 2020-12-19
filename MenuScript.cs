using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject Tutorial;
    public int AfterTutorial;
    public GameObject mENU;
    public GameObject pl;
    public GameObject spawner;
    public GameObject StarCounter;
    public GameObject LevelList;

   // public Slider Charge;
    public Slider OffFall;

    public void Start()
    {
        OffFall.value = PlayerPrefs.GetFloat("fall", OffFall.value);
        AfterTutorial = PlayerPrefs.GetInt("AfterTutorial");
     // Charge.value = PlayerPrefs.GetFloat("Charge", Charge.value);        
        if (AfterTutorial == 1)
        {
            Tutorial.SetActive(false);
            mENU.SetActive(true);
            pl.SetActive(true);
            StarCounter.SetActive(true);
            spawner.SetActive(true);
        }
        else 
        {
            StarCounter.SetActive(false);
            Tutorial.SetActive(true);
            mENU.SetActive(false);
            spawner.SetActive(false);
        }
    }

    public void Update()
    {

        PlayerPrefs.SetFloat("fall", OffFall.value);
       // PlayerPrefs.SetFloat("Charge",Charge.value);
        if (OffFall.value == 1)
        {
            spawner.SetActive(true);
        }
        else
        {
            spawner.SetActive(false);
        }
    }

    public void Play() 
    {
        PlayerPrefs.SetInt("Selected", ReplayScript.SelectReplayLevel);
        ReplayScript.SelectReplayLevel = 0;
        if (LevelSystem.LevelSelected == 1) 
        {
            SceneManager.LoadScene(1);
        }

        if (LevelSystem.LevelSelected == 2)
        {
            SceneManager.LoadScene(2);
        }

        if (LevelSystem.LevelSelected == 3)
        {
            SceneManager.LoadScene(3);
        }

        if (LevelSystem.LevelSelected == 4)
        {
            SceneManager.LoadScene(4);
        }

        if (LevelSystem.LevelSelected == 5)
        {
            SceneManager.LoadScene(5);
        }

        if (LevelSystem.LevelSelected == 6)
        {
            SceneManager.LoadScene(6);
        }

        if (LevelSystem.LevelSelected == 7)
        {
            SceneManager.LoadScene(7);
        }

        if (LevelSystem.LevelSelected == 8)
        {
            SceneManager.LoadScene(8);
        }

        if (LevelSystem.LevelSelected == 9)
        {
            SceneManager.LoadScene(9);
        }

        if (LevelSystem.LevelSelected == 10)
        {
            SceneManager.LoadScene(10);
        }

        if (LevelSystem.LevelSelected == 11)
        {
            SceneManager.LoadScene(11);
        }

        if (LevelSystem.LevelSelected == 12)
        {
            SceneManager.LoadScene(12);
        }

        if (LevelSystem.LevelSelected == 13)
        {
            SceneManager.LoadScene(13);
        }

        if (LevelSystem.LevelSelected == 14)
        {
            SceneManager.LoadScene(14);
        }

        if (LevelSystem.LevelSelected == 15)
        {
            SceneManager.LoadScene(15);
        }

        if (LevelSystem.LevelSelected == 16)
        {
            SceneManager.LoadScene(16);
        }

        if (LevelSystem.LevelSelected == 17)
        {
            SceneManager.LoadScene(17);
        }

        if (LevelSystem.LevelSelected == 18)
        {
            SceneManager.LoadScene(18);
        }

        if (LevelSystem.LevelSelected == 19)
        {
            SceneManager.LoadScene(19);
        }

        if (LevelSystem.LevelSelected == 20)
        {
            SceneManager.LoadScene(22);
        }

        if (LevelSystem.LevelSelected == 21)
        {
            SceneManager.LoadScene(21);
        }

        if (LevelSystem.LevelSelected == 22)
        {
            SceneManager.LoadScene(22);
        }

        if (LevelSystem.LevelSelected == 23)
        {
            SceneManager.LoadScene(23);
        }

        if (LevelSystem.LevelSelected == 24)
        {
            SceneManager.LoadScene(24);
        }

        if (LevelSystem.LevelSelected == 25)
        {
            SceneManager.LoadScene(25);
        }

        if (LevelSystem.LevelSelected == 26)
        {
            SceneManager.LoadScene(26);
        }

        if (LevelSystem.LevelSelected == 27)
        {
            SceneManager.LoadScene(27);
        }

        if (LevelSystem.LevelSelected == 28)
        {
            SceneManager.LoadScene(28);
        }

        if (LevelSystem.LevelSelected == 29)
        {
            SceneManager.LoadScene(29);
        }

        if (LevelSystem.LevelSelected == 30)
        {
            SceneManager.LoadScene(30);
        }

        if (LevelSystem.LevelSelected == 0) 
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void EndTutorial() 
    {
        AfterTutorial = 1;
        PlayerPrefs.SetInt("AfterTutorial", AfterTutorial);
        mENU.SetActive(true);
        Tutorial.SetActive(false);
        SceneManager.LoadScene("Menu");
    }

    public void OffFalling() 
    {
        spawner.GetComponent<Spawner>().enabled = !spawner.GetComponent<Spawner>().enabled;
    }

    public void ToLevelList() 
    {
        mENU.SetActive(false);
        LevelList.SetActive(true);
    }
}
