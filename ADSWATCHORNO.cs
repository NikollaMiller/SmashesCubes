using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ADSWATCHORNO : MonoBehaviour
{
    public GameObject IFHAVENTSTARS;
    public GameObject IfHaveStars;
    public GameObject Wall;
    public Animator podskazka;
    private int smenperuse =5;
    private int plus;

    public GameObject[] redPlacements;

    public void YesWannaGetHelp() 
    {
        if (StarSystem.AllStars >= smenperuse)
        {
            StarSystem.AllStars = StarSystem.AllStars - smenperuse;
            plus += 1;
            redPlacements[0].SetActive(true);
            podskazka.SetInteger("podskazka",1);
            Invoke("closePodskazka",1);
        }
        else 
        {
            IFHAVENTSTARS.SetActive(true);
            IfHaveStars.SetActive(false);
        }
    }

    public void ClosePoskazku() 
    {
        podskazka.SetInteger("podskazka", 1);
        Invoke("closePodskazka", 1);
    }

    private void closePodskazka() 
    {
        Wall.SetActive(false);
    }

    public void WatchAdToHelps() 
    {
        if (Advertisement.IsReady()) 
        {
            if (LevelSystem.LevelSelected == 1)
            {
                podskazka.SetInteger("podskazka", 1);
                redPlacements[0].SetActive(true);
                Invoke("closePodskazka", 1);
            }
            else if (LevelSystem.LevelSelected == 2)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[0].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 3)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[0].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 4)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[2].SetActive(true);
                redPlacements[0].SetActive(true);
                redPlacements[1].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 5)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[0].SetActive(true);
                redPlacements[1].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 6)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[0].SetActive(true);
                redPlacements[1].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 7)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[0].SetActive(true);
                redPlacements[1].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 8)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[1].SetActive(true);
                redPlacements[0].SetActive(true);
                redPlacements[2].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 9)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[1].SetActive(true);
                redPlacements[0].SetActive(true);
                redPlacements[2].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 10)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[1].SetActive(true);
                redPlacements[0].SetActive(true);
                redPlacements[2].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 11)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[10].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 12)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[11].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 13)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[12].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 14)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[13].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 15)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[14].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 16)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[15].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 17)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[16].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 18)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[17].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 19)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[18].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 20)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[19].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 21)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[20].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 22)
            {
                redPlacements[21].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 23)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[22].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 24)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[23].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 25)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[24].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 26)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[25].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 27)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[26].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 28)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[27].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 29)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[28].SetActive(true);
            }
            else if (LevelSystem.LevelSelected == 30)
            {
                podskazka.SetInteger("podskazka", 1);
                Invoke("closePodskazka", 1);
                redPlacements[29].SetActive(true);
            }
            Advertisement.Show("rewardedVideo");
        }
    }
        
}
