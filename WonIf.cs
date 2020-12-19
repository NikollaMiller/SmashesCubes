using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonIf : MonoBehaviour
{
    public int cubs;
    public int desathCubes;
    public GameObject Pessed;
    public GameObject Loose;
    public GameObject Replayed;
    public GameObject Panelka;
    public int limit;

    public void Update()
    {
        if (cubs <= 0 && ReplayScript.SelectReplayLevel == 0)
        {
            Invoke("Chtotam", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 1)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 2)
        {
            Invoke("CtototamTolkoReplay", 1);
        }

        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 3)
        {
            Invoke("CtototamTolkoReplay", 1);
        }

        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 4)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 5)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 6)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 7)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 8)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 9)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 10)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 11)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 12)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 13)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 14)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 15)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 16)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 17)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 18)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 19)
        {
            Replayed.SetActive(true);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 20)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 21)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 22)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 23)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 24)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 25)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 26)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 27)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 28)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 29)
        {
            Invoke("CtototamTolkoReplay", 1);
        }
        else if (cubs <= 0 && ReplayScript.SelectReplayLevel == 30)
        {
            Invoke("CtototamTolkoReplay",1);
        }

        if (desathCubes < limit)
        {
            Invoke("ChtotamTolkoLoose", 1);
        }
    }

    private void Chtotam() 
    {
        Pessed.SetActive(true);
        Panelka.SetActive(true);
    }

    private void ChtotamTolkoLoose() 
    {
        Panelka.SetActive(true);
        Loose.SetActive(true);
    }

    private void CtototamTolkoReplay() 
    {
        Replayed.SetActive(true);
    }

}
