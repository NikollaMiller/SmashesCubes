using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class few : MonoBehaviour
{
    public GameObject pauseBn;
    public void Start()
    {
       ReplayScript.SelectReplayLevel = PlayerPrefs.GetInt("Selected");
       Debug.Log(ReplayScript.SelectReplayLevel);

        if (ReplayScript.SelectReplayLevel == 1)
        {
            pauseBn.SetActive(false);
        }
        else if (ReplayScript.SelectReplayLevel == 2)
        {
            pauseBn.SetActive(false);
        }
        else if (ReplayScript.SelectReplayLevel == 3)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 4)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 5)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 6)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 7)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 8)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 9)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 10)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 11)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 12)
        {
            pauseBn.SetActive(false);
        }
        else if (ReplayScript.SelectReplayLevel == 13)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 14)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 15)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 16)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 17)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 18)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 19)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 20)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 21)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 22)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 23)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 24)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 25)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 26)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 27)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 28)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 29)
        {
            pauseBn.SetActive(false);
        }

        else if (ReplayScript.SelectReplayLevel == 30)
        {
            pauseBn.SetActive(false);
        }
    }
    public void EndReplay() 
    {
        if (ReplayScript.SelectReplayLevel == 1)
        {
            ReplayScript.StarsForReplay[0] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing1", ReplayScript.StarsForReplay[0]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }
        else if (ReplayScript.SelectReplayLevel == 2)
        {
            ReplayScript.StarsForReplay[1] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing2", ReplayScript.StarsForReplay[1]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            Debug.Log(ReplayScript.StarsForReplay[1]);
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }
        else if (ReplayScript.SelectReplayLevel == 3) 
        {
            ReplayScript.StarsForReplay[2] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing3", ReplayScript.StarsForReplay[2]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if(ReplayScript.SelectReplayLevel == 4)
        {
            ReplayScript.StarsForReplay[3] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing4", ReplayScript.StarsForReplay[3]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if(ReplayScript.SelectReplayLevel == 5)
        {
            ReplayScript.StarsForReplay[4] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing5", ReplayScript.StarsForReplay[4]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 6)
        {
            ReplayScript.StarsForReplay[5] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing6", ReplayScript.StarsForReplay[5]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 7)
        {
            ReplayScript.StarsForReplay[6] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing7", ReplayScript.StarsForReplay[6]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 8)
        {
            ReplayScript.StarsForReplay[7] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing8", ReplayScript.StarsForReplay[7]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 9)
        {
            ReplayScript.StarsForReplay[8] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing9", ReplayScript.StarsForReplay[8]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 10)
        {
            ReplayScript.StarsForReplay[9] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing10", ReplayScript.StarsForReplay[9]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 11)
        {
            ReplayScript.StarsForReplay[10] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing11", ReplayScript.StarsForReplay[10]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 12)
        {
            ReplayScript.StarsForReplay[11] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing12", ReplayScript.StarsForReplay[11]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 13)
        {
            ReplayScript.StarsForReplay[12] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing13", ReplayScript.StarsForReplay[12]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 14)
        {
            ReplayScript.StarsForReplay[13] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing14", ReplayScript.StarsForReplay[13]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 15)
        {
            ReplayScript.StarsForReplay[14] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing15", ReplayScript.StarsForReplay[14]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 16)
        {
            ReplayScript.StarsForReplay[15] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing16", ReplayScript.StarsForReplay[15]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 17)
        {
            ReplayScript.StarsForReplay[16] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing17", ReplayScript.StarsForReplay[16]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 18)
        {
            ReplayScript.StarsForReplay[17] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing18", ReplayScript.StarsForReplay[17]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 19)
        {
            ReplayScript.StarsForReplay[18] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing19", ReplayScript.StarsForReplay[18]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 20)
        {           
            ReplayScript.StarsForReplay[19] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing20", ReplayScript.StarsForReplay[19]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 21)
        {
            ReplayScript.StarsForReplay[20] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing21", ReplayScript.StarsForReplay[20]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 22)
        {
            ReplayScript.StarsForReplay[21] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing22", ReplayScript.StarsForReplay[21]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 23)
        {
            ReplayScript.StarsForReplay[22] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing23", ReplayScript.StarsForReplay[22]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 24)
        {
            ReplayScript.StarsForReplay[23] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing24", ReplayScript.StarsForReplay[23]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 25)
        {
            ReplayScript.StarsForReplay[24] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing25", ReplayScript.StarsForReplay[24]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 26)
        {
            ReplayScript.StarsForReplay[25] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing26", ReplayScript.StarsForReplay[25]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 27)
        {
            ReplayScript.StarsForReplay[26] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing27", ReplayScript.StarsForReplay[26]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 28)
        {
            ReplayScript.StarsForReplay[27] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing28", ReplayScript.StarsForReplay[27]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 29)
        {
            ReplayScript.StarsForReplay[28] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing29", ReplayScript.StarsForReplay[28]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }

        else if (ReplayScript.SelectReplayLevel == 30)
        {
           ReplayScript.StarsForReplay[29] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing30", ReplayScript.StarsForReplay[29]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }
    }
}
