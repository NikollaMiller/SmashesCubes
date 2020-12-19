using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNext : MonoBehaviour
{
    public GameObject del;
    public GameObject notEnoughStars;
    public Transform buttonPos;

    public void Start()
    {  
    }
    public void Next() 
    {
        if (LevelSystem.LevelSelected == 1 || LevelSystem.LevelSelected == 0) 
        {
            StarSystem.Comepleted[0] = 1;
            LevelSystem.LevelSelected = 2;
            ReplayScript.StarsForReplay[0] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing1", ReplayScript.StarsForReplay[0]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls",LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come1", StarSystem.Comepleted[0]);
        }
        else if (LevelSystem.LevelSelected == 2)
        {
            StarSystem.Comepleted[1] = 2;
            LevelSystem.LevelSelected = 3;
            ReplayScript.StarsForReplay[1] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing2", ReplayScript.StarsForReplay[1]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come2", StarSystem.Comepleted[1]);
        }
        else if(LevelSystem.LevelSelected == 3)
        {
            StarSystem.Comepleted[2] = 3;
            LevelSystem.LevelSelected = 4;
            ReplayScript.StarsForReplay[2] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing3", ReplayScript.StarsForReplay[2]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come3", StarSystem.Comepleted[2]);
        }
        else if(LevelSystem.LevelSelected == 4)
        {
            StarSystem.Comepleted[3] = 4;
            LevelSystem.LevelSelected = 5;
            ReplayScript.StarsForReplay[3] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing4", ReplayScript.StarsForReplay[3]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come4", StarSystem.Comepleted[3]);
        }
        else if(LevelSystem.LevelSelected == 5)
        {
            StarSystem.Comepleted[4] = 5;
            LevelSystem.LevelSelected = 6;
            ReplayScript.StarsForReplay[4] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing5", ReplayScript.StarsForReplay[4]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come5", StarSystem.Comepleted[4]);
        }
        else if(LevelSystem.LevelSelected == 6)
        {
            StarSystem.Comepleted[5] = 6;
            LevelSystem.LevelSelected = 7;
            ReplayScript.StarsForReplay[5] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing6", ReplayScript.StarsForReplay[5]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come6", StarSystem.Comepleted[5]);
        }
        else if(LevelSystem.LevelSelected == 7)
        {
            StarSystem.Comepleted[6] = 7;
            LevelSystem.LevelSelected = 8;
            ReplayScript.StarsForReplay[6] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing7", ReplayScript.StarsForReplay[6]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come7", StarSystem.Comepleted[6]);
        }
        else if(LevelSystem.LevelSelected == 8)
        {
            StarSystem.Comepleted[7] = 8;
            LevelSystem.LevelSelected = 9;
            ReplayScript.StarsForReplay[7] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing8", ReplayScript.StarsForReplay[7]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come8", StarSystem.Comepleted[7]);
        }
        else if(LevelSystem.LevelSelected == 9)
        {
            StarSystem.Comepleted[8] = 9;
            LevelSystem.LevelSelected = 10;
             ReplayScript.StarsForReplay[8] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing9", ReplayScript.StarsForReplay[8]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come9", StarSystem.Comepleted[8]);
        }
        else if(LevelSystem.LevelSelected == 10)
        {
            StarSystem.Comepleted[9] = 10;
            LevelSystem.LevelSelected = 11;
            ReplayScript.StarsForReplay[9] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing10", ReplayScript.StarsForReplay[9]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come10", StarSystem.Comepleted[9]);
        }
        else if(LevelSystem.LevelSelected == 11)
        {
            StarSystem.Comepleted[10] = 11;
            LevelSystem.LevelSelected = 12;
            ReplayScript.StarsForReplay[10] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing11", ReplayScript.StarsForReplay[10]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come11", StarSystem.Comepleted[10]);
        }
        else if(LevelSystem.LevelSelected == 12)
        {
            StarSystem.Comepleted[11] = 12;
            LevelSystem.LevelSelected = 13;
            ReplayScript.StarsForReplay[11] =  StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing12", ReplayScript.StarsForReplay[11]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come12", StarSystem.Comepleted[11]);
        }
        else if(LevelSystem.LevelSelected == 13)
        {
            StarSystem.Comepleted[12] = 13;
            LevelSystem.LevelSelected = 14;
           ReplayScript.StarsForReplay[12] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing13", ReplayScript.StarsForReplay[12]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come13", StarSystem.Comepleted[12]);
        }
        else if(LevelSystem.LevelSelected == 14)
        {
            StarSystem.Comepleted[13] = 14;
            LevelSystem.LevelSelected = 15;
            ReplayScript.StarsForReplay[13] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing14", ReplayScript.StarsForReplay[13]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come14", StarSystem.Comepleted[13]);
        }
        else if(LevelSystem.LevelSelected == 15)
        {
            StarSystem.Comepleted[14] = 15;
            LevelSystem.LevelSelected = 16;
            ReplayScript.StarsForReplay[14] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing15", ReplayScript.StarsForReplay[14]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come15", StarSystem.Comepleted[14]);
        }
        else if(LevelSystem.LevelSelected == 16)
        {
            StarSystem.Comepleted[15] = 16;
            LevelSystem.LevelSelected = 17;
            ReplayScript.StarsForReplay[15] =StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing16", ReplayScript.StarsForReplay[15]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come16", StarSystem.Comepleted[15]);
        }
        else if(LevelSystem.LevelSelected == 17)
        {
            StarSystem.Comepleted[16] = 17;
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected = 18;
            ReplayScript.StarsForReplay[16] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing17", ReplayScript.StarsForReplay[16]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come17", StarSystem.Comepleted[16]);
        }
        else if(LevelSystem.LevelSelected == 18)
        {
            StarSystem.Comepleted[17] = 18;
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected = 19;
            ReplayScript.StarsForReplay[17] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing18", ReplayScript.StarsForReplay[17]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come18", StarSystem.Comepleted[17]); 
        }
        else if(LevelSystem.LevelSelected == 19)
        {
            StarSystem.Comepleted[18] = 19;
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected = 20;
            ReplayScript.StarsForReplay[18] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing19", ReplayScript.StarsForReplay[18]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come19", StarSystem.Comepleted[18]);
        }
        else if(LevelSystem.LevelSelected == 20)
        {
            StarSystem.Comepleted[19] = 20;
            LevelSystem.LevelSelected = 21;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[19] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing20", ReplayScript.StarsForReplay[19]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come20", StarSystem.Comepleted[19]);
        }
        else if(LevelSystem.LevelSelected == 21)
        {
            StarSystem.Comepleted[20] = 21;
            LevelSystem.LevelSelected = 22;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[20] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing21", ReplayScript.StarsForReplay[20]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come21", StarSystem.Comepleted[20]);
        }
        else if(LevelSystem.LevelSelected == 22 )
        {
            StarSystem.Comepleted[21] = 22;
            LevelSystem.LevelSelected = 23;
            ReplayScript.StarsForReplay[21] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing22", ReplayScript.StarsForReplay[21]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come22", StarSystem.Comepleted[21]);
        }
        else if(LevelSystem.LevelSelected == 23 )
        {
            StarSystem.Comepleted[22] = 23;
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected = 24;
            ReplayScript.StarsForReplay[22] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing23", ReplayScript.StarsForReplay[22]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come23", StarSystem.Comepleted[22]);
        }
        else if(LevelSystem.LevelSelected == 24)
        {
            StarSystem.Comepleted[23] = 24;
            LevelSystem.LevelSelected = 25;
            ReplayScript.StarsForReplay[23] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing24", ReplayScript.StarsForReplay[23]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come24", StarSystem.Comepleted[23]);
        }
        else if(LevelSystem.LevelSelected == 25)
        {
            StarSystem.Comepleted[24] = 25;
            LevelSystem.LevelSelected = 26;
            ReplayScript.StarsForReplay[24] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing25", ReplayScript.StarsForReplay[24]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come25", StarSystem.Comepleted[24]);
        }
        else if(LevelSystem.LevelSelected == 26)
        {
            StarSystem.Comepleted[25] = 26;
            LevelSystem.LevelSelected = 27;
            ReplayScript.StarsForReplay[25] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing26", ReplayScript.StarsForReplay[25]);
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come26", StarSystem.Comepleted[25]);
        }
        else if(LevelSystem.LevelSelected == 27)
        {
            StarSystem.Comepleted[26] = 27;
            ReplayScript.StarsForReplay[26] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing27", ReplayScript.StarsForReplay[26]);
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected = 28;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come27", StarSystem.Comepleted[26]);
        }
        else if(LevelSystem.LevelSelected == 28)
        {
            StarSystem.Comepleted[27] = 28;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[27] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing28", ReplayScript.StarsForReplay[27]);
            LevelSystem.LevelSelected = 29;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come28", StarSystem.Comepleted[27]);
        }
        else if(LevelSystem.LevelSelected == 29)
        {
            StarSystem.Comepleted[28] = 29;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[28] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing29", ReplayScript.StarsForReplay[28]);
            LevelSystem.LevelSelected = 30;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come29", StarSystem.Comepleted[28]);
        }
        else if(LevelSystem.LevelSelected == 30)
        {
            StarSystem.Comepleted[29] = 30;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[29] = StarEarn.Stars;
            PlayerPrefs.SetInt("Replaing30", ReplayScript.StarsForReplay[29]);
            LevelSystem.LevelSelected = 0;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
            PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
            PlayerPrefs.SetInt("come30", StarSystem.Comepleted[29]);
        }

        Invoke("nextik", 1.8f);
    }

    public void Again() 
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        del.SetActive(false);
    }

    public void NExtStage()
    {

        if (StarSystem.AllStars >= 12)
        {
            int scene = SceneManager.GetActiveScene().buildIndex;
            scene = scene + 1;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
        else 
        {
            Instantiate(notEnoughStars,buttonPos);
            notEnoughStars.SetActive(true);
        }

    }

    public void nextik() 
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        scene = scene + 1;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void Stagers() 
    {
        StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
    }
}
