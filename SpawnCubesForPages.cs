using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnCubesForPages : MonoBehaviour
{
    public GameObject[] cbe;
    public GameObject Levels;
    public Animator LevelsClosed;
    public Animator OptionsClosed;
    public GameObject Menu;
    public GameObject Options;
    public Transform pos;
    public SpawnCubesForPages Spawner;
    public KilCubes opyat;
    public float Width;
    public Spawner menuSpawner;
    public GameObject MenuStarcount;
    public GameObject MenuPlat;
    public static int agahochu;
    public bool no;

    public void Start()
    {
        Spawner = GetComponent<SpawnCubesForPages>();
    }

    void Update()
    {
        for (int i = 0; i < cbe.Length; i++)
        {
            var cell = Instantiate(cbe[i], pos);
            cell.transform.localPosition = new Vector3(Random.Range(0, Width), 0, 0);
        }

    }

    public void FallActive() 
    {
        menuSpawner.enabled = true;
    }

    public void FallDeactive() 
    {
        menuSpawner.enabled = false;
    }

    public void ToLevels() 
    {
        LevelsClosed.SetInteger("CloseLevel", 0);
        opyat.enabled = false;
        Spawner.enabled = true;
        Invoke("Open",1.3f);
        MenuPlat.SetActive(false); 
        menuSpawner.enabled = false;
    }

    public void CloseLevels() 
    {
        LevelsClosed.SetInteger("CloseLevel", 1);
        opyat.enabled = false;
        menuSpawner.enabled = true;
        Spawner.enabled = true;
        Invoke("Close", 1.8f);
    }

    public void Open() 
    {
        opyat.enabled = true;
        Spawner.enabled = false;
        Levels.SetActive(true);
       
        menuSpawner.enabled = true;
    }

    public void Close() 
    {
        Levels.SetActive(false);
        MenuStarcount.SetActive(true);
        opyat.enabled = true;
        Spawner.enabled = false;
        MenuPlat.SetActive(true);
        menuSpawner.enabled = true;
        Menu.SetActive(true);
    }

    public void ToOptions() 
    {
        OptionsClosed.SetInteger("closeOptions",0);
        Spawner.enabled = true;
        Invoke("OptionsOpen", 1.3f);
        MenuPlat.SetActive(false);
        menuSpawner.enabled = false;
    }

    public void OptionsOpen() 
    {
        menuSpawner.enabled = true;
        Spawner.enabled = false;
        Options.SetActive(true);
    }

    public void LeaveFromOpt() 
    {
        OptionsClosed.SetInteger("closeOptions", 1);
        menuSpawner.enabled = false;
        Spawner.enabled = true;
        Invoke("CloseOpt", 1.8f);
    }

    public void CloseOpt() 
    {
        Options.SetActive(false);
        Spawner.enabled = false;
        MenuPlat.SetActive(true);
        MenuStarcount.SetActive(true);
        menuSpawner.enabled = true;
        Menu.SetActive(true);
    }

    public void Play()
    {
        PlayerPrefs.SetInt("Selected", ReplayScript.SelectReplayLevel);
        ReplayScript.SelectReplayLevel = 0;
        menuSpawner.enabled = false;
        MenuPlat.SetActive(false);
        Invoke("PlayFallCubes",0.8f);
        Invoke("PlayMoution",2.1f);
        agahochu = 1;
    }
    public void PlayFallCubes() 
    {
        Spawner.enabled = true;
    }
    public void PlayMoution() 
    {
        if (LevelSystem.LevelSelected == 1)
        {
            SceneManager.LoadScene("1");
        }

        if (LevelSystem.LevelSelected == 2)
        {
            SceneManager.LoadScene(3);
        }

        if (LevelSystem.LevelSelected == 3)
        {
            SceneManager.LoadScene(4);
        }

        if (LevelSystem.LevelSelected == 4)
        {
            SceneManager.LoadScene(5);
        }

        if (LevelSystem.LevelSelected == 5)
        {
            SceneManager.LoadScene(6);
        }

        if (LevelSystem.LevelSelected == 6)
        {
            SceneManager.LoadScene(7);
        }

        if (LevelSystem.LevelSelected == 7)
        {
            SceneManager.LoadScene(8);
        }

        if (LevelSystem.LevelSelected == 8)
        {
            SceneManager.LoadScene(9);
        }

        if (LevelSystem.LevelSelected == 9)
        {
            SceneManager.LoadScene(10);
        }

        if (LevelSystem.LevelSelected == 10)
        {
            SceneManager.LoadScene(11);
        }

        if (LevelSystem.LevelSelected == 11)
        {
            SceneManager.LoadScene(12);
        }

        if (LevelSystem.LevelSelected == 12)
        {
            SceneManager.LoadScene(13);
        }

        if (LevelSystem.LevelSelected == 13)
        {
            SceneManager.LoadScene(14);
        }

        if (LevelSystem.LevelSelected == 14)
        {
            SceneManager.LoadScene(15);
        }

        if (LevelSystem.LevelSelected == 15)
        {
            SceneManager.LoadScene(16);
        }

        if (LevelSystem.LevelSelected == 16)
        {
            SceneManager.LoadScene(17);
        }

        if (LevelSystem.LevelSelected == 17)
        {
            SceneManager.LoadScene(18);
        }

        if (LevelSystem.LevelSelected == 18)
        {
            SceneManager.LoadScene(19);
        }

        if (LevelSystem.LevelSelected == 19)
        {
            SceneManager.LoadScene(20);
        }

        if (LevelSystem.LevelSelected == 20)
        {
            SceneManager.LoadScene(21);
        }

        if (LevelSystem.LevelSelected == 21)
        {
            SceneManager.LoadScene(22);
        }

        if (LevelSystem.LevelSelected == 22)
        {
            SceneManager.LoadScene(23);
        }

        if (LevelSystem.LevelSelected == 23)
        {
            SceneManager.LoadScene(24);
        }

        if (LevelSystem.LevelSelected == 24)
        {
            SceneManager.LoadScene(25);
        }

        if (LevelSystem.LevelSelected == 25)
        {
            SceneManager.LoadScene(26);
        }

        if (LevelSystem.LevelSelected == 26)
        {
            SceneManager.LoadScene(27);
        }

        if (LevelSystem.LevelSelected == 27)
        {
            SceneManager.LoadScene(28);
        }

        if (LevelSystem.LevelSelected == 28)
        {
            SceneManager.LoadScene(29);
        }

        if (LevelSystem.LevelSelected == 29)
        {
            SceneManager.LoadScene(30);
        }

        if (LevelSystem.LevelSelected == 30)
        {
            SceneManager.LoadScene(31);
        }

        if (LevelSystem.LevelSelected == 0)
        {
            SceneManager.LoadScene("1");
        }
    }
}
