using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarSystem : MonoBehaviour
{
    public Text AllStarsTrack;
    public Text AllStarsTrackBG;

    public Text ToNExtAge;

    public GameObject[] UnlockStage;
    public GameObject[] BlackPage;
    public GameObject[] Complete;
    public GameObject[] NotEnoughtStars;
    public Transform[] ButtonPos;

    public static int AllStars;
    public int[] saveUnlockedStage;
    public static int[] Comepleted = new int[30];
    public int Plus = 12;

    public void Start()
    {
        NotEnoughtStars[0].SetActive(false);
        NotEnoughtStars[1].SetActive(false);
        AllStars = PlayerPrefs.GetInt("AllStar");
        saveUnlockedStage[0] = PlayerPrefs.GetInt("saveUnlockedStage");
        saveUnlockedStage[1] = PlayerPrefs.GetInt("saveUnlockedStage1");
        Comepleted[0] = PlayerPrefs.GetInt("come1");
        Comepleted[1] = PlayerPrefs.GetInt("come2");
        Comepleted[2] = PlayerPrefs.GetInt("come3");
        Comepleted[3] = PlayerPrefs.GetInt("come4");
        Comepleted[4] = PlayerPrefs.GetInt("come5");
        Comepleted[5] = PlayerPrefs.GetInt("come6");
        Comepleted[6] = PlayerPrefs.GetInt("come7");
        Comepleted[7] = PlayerPrefs.GetInt("come8");
        Comepleted[8] = PlayerPrefs.GetInt("come9");
        Comepleted[9] = PlayerPrefs.GetInt("come10");
        Comepleted[10] = PlayerPrefs.GetInt("come11");
        Comepleted[11] = PlayerPrefs.GetInt("come12");
        Comepleted[12] = PlayerPrefs.GetInt("come13");
        Comepleted[13] = PlayerPrefs.GetInt("come14");
        Comepleted[14] = PlayerPrefs.GetInt("come15");
        Comepleted[15] = PlayerPrefs.GetInt("come16");
        Comepleted[16] = PlayerPrefs.GetInt("come17");
        Comepleted[17] = PlayerPrefs.GetInt("come18");
        Comepleted[18] = PlayerPrefs.GetInt("come19");
        Comepleted[19] = PlayerPrefs.GetInt("come20");
        Comepleted[20] = PlayerPrefs.GetInt("come21");
        Comepleted[21] = PlayerPrefs.GetInt("come22");
        Comepleted[22] = PlayerPrefs.GetInt("come23");
        Comepleted[23] = PlayerPrefs.GetInt("come24");
        Comepleted[24] = PlayerPrefs.GetInt("come25");
        Comepleted[25] = PlayerPrefs.GetInt("come26");
        Comepleted[26] = PlayerPrefs.GetInt("come27");
        Comepleted[27] = PlayerPrefs.GetInt("come28");
        Comepleted[28] = PlayerPrefs.GetInt("come29");
        Comepleted[29] = PlayerPrefs.GetInt("come30");
    }

    public void Update()
    {

        if (Comepleted[0] == 1)
        {
            Complete[0].SetActive(true);
            BlackPage[0].SetActive(false);
            BlackPage[1].SetActive(false);
        }

        if (Comepleted[1] == 2)
        {
            Complete[1].SetActive(true);
            BlackPage[1].SetActive(false);
            BlackPage[2].SetActive(false);
        }

        if (Comepleted[2] == 3)
        {
            Complete[2].SetActive(true);
            BlackPage[2].SetActive(false);
            BlackPage[3].SetActive(false);
        }

        if (Comepleted[3] == 4)
        {
            Complete[3].SetActive(true);
            BlackPage[3].SetActive(false);
            BlackPage[4].SetActive(false);
        }

        if (Comepleted[4] ==5)
        {
            Complete[4].SetActive(true);
            BlackPage[4].SetActive(false);
            BlackPage[5].SetActive(false);
        }

        if (Comepleted[5] == 6)
        {
            Complete[5].SetActive(true);
            BlackPage[5].SetActive(false);
            BlackPage[6].SetActive(false);
        }

        if (Comepleted[6] == 7)
        {
            Complete[6].SetActive(true);
            BlackPage[6].SetActive(false);
            BlackPage[7].SetActive(false);
        }

        if (Comepleted[7] == 8)
        {
            Complete[7].SetActive(true);
            BlackPage[7].SetActive(false);
            BlackPage[8].SetActive(false);
        }

        if (Comepleted[8] == 9)
        {
            Complete[8].SetActive(true);
            BlackPage[8].SetActive(false);
            BlackPage[9].SetActive(false);
        }

        if (Comepleted[9] == 10)
        {
            Complete[9].SetActive(true);
            BlackPage[9].SetActive(false);
            BlackPage[10].SetActive(false);
        }

        if (Comepleted[10] == 11)
        {
            Complete[10].SetActive(true);
            BlackPage[10].SetActive(false);
            BlackPage[11].SetActive(false);
        }

        if (Comepleted[11] == 12)
        {
            Complete[11].SetActive(true);
            BlackPage[11].SetActive(false);
            BlackPage[12].SetActive(false);
        }

        if (Comepleted[12] == 13)
        {
            Complete[12].SetActive(true);
            BlackPage[12].SetActive(false);
            BlackPage[13].SetActive(false);
        }

        if (Comepleted[13] == 14)
        {
            Complete[13].SetActive(true);
            BlackPage[13].SetActive(false);
            BlackPage[14].SetActive(false);
        }

        if (Comepleted[14] == 15)
        {
            Complete[14].SetActive(true);
            BlackPage[14].SetActive(false);
            BlackPage[15].SetActive(false);
        }

        if (Comepleted[15] == 16)
        {
            Complete[15].SetActive(true);
            BlackPage[15].SetActive(false);
            BlackPage[16].SetActive(false);
        }

        if (Comepleted[16] == 17)
        {
            Complete[16].SetActive(true);
            BlackPage[16].SetActive(false);
            BlackPage[17].SetActive(false);
        }

        if (Comepleted[17] == 18)
        {
            Complete[17].SetActive(true);
            BlackPage[17].SetActive(false);
            BlackPage[18].SetActive(false);
        }

        if (Comepleted[18] == 19)
        {
            Complete[18].SetActive(true);
            BlackPage[18].SetActive(false);
            BlackPage[19].SetActive(false);
        }

        if (Comepleted[19] == 20)
        {
            Complete[19].SetActive(true);
            BlackPage[19].SetActive(false);
            BlackPage[20].SetActive(false);
        }

        if (Comepleted[20] == 21)
        {
            Complete[20].SetActive(true);
            BlackPage[20].SetActive(false);
            BlackPage[21].SetActive(false);
        }

        if (Comepleted[21] == 22)
        {
            Complete[21].SetActive(true);
            BlackPage[21].SetActive(false);
            BlackPage[22].SetActive(false);
        }

        if (Comepleted[22] == 23)
        {
            Complete[22].SetActive(true);
            BlackPage[22].SetActive(false);
            BlackPage[23].SetActive(false);
        }

        if (Comepleted[23] == 24)
        {
            Complete[23].SetActive(true);
            BlackPage[23].SetActive(false);
            BlackPage[24].SetActive(false);
        }

        if (Comepleted[24] == 25)
        {
            Complete[24].SetActive(true);
            BlackPage[24].SetActive(false);
            BlackPage[25].SetActive(false);
        }

        if (Comepleted[25] == 26)
        {
            Complete[25].SetActive(true);
            BlackPage[25].SetActive(false);
            BlackPage[26].SetActive(false);
        }

        if (Comepleted[26] == 27)
        {
            Complete[26].SetActive(true);
            BlackPage[26].SetActive(false);
            BlackPage[27].SetActive(false);
        }

        if (Comepleted[27] == 28)
        {
            Complete[27].SetActive(true);
            BlackPage[27].SetActive(false);
            BlackPage[28].SetActive(false);
        }

        if (Comepleted[28] == 29)
        {
            Complete[28].SetActive(true);
            BlackPage[28].SetActive(false);
            BlackPage[29].SetActive(false);
        }

        if (Comepleted[29] == 30)
        {
            Complete[29].SetActive(true);
            BlackPage[29].SetActive(false);
        }

        ToNExtAge.text = Plus - AllStars + "X";

        if (saveUnlockedStage[0] == 1) 
        {
            UnlockStage[0].SetActive(false);
            BlackPage[11].SetActive(false);
            BlackPage[12].SetActive(false);
            BlackPage[13].SetActive(false);
            BlackPage[14].SetActive(false);
            BlackPage[15].SetActive(false);
            BlackPage[16].SetActive(false);
            BlackPage[17].SetActive(false);
            BlackPage[18].SetActive(false);
            BlackPage[19].SetActive(false);
            BlackPage[20].SetActive(false);

        }

        if (saveUnlockedStage[1] == 2)
        {
            UnlockStage[1].SetActive(false);
            BlackPage[21].SetActive(false);
            BlackPage[22].SetActive(false);
            BlackPage[23].SetActive(false);
            BlackPage[24].SetActive(false);
            BlackPage[25].SetActive(false);
            BlackPage[26].SetActive(false);
            BlackPage[27].SetActive(false);
            BlackPage[28].SetActive(false);
            BlackPage[29].SetActive(false);
        }

        PlayerPrefs.SetInt("saveUnlockedStage", saveUnlockedStage[0]);
        PlayerPrefs.SetInt("saveUnlockedStage1", saveUnlockedStage[1]);
        PlayerPrefs.SetInt("AllStar", AllStars);
        PlayerPrefs.SetInt("come1",Comepleted[0]);
        PlayerPrefs.SetInt("come2", Comepleted[1]);
        PlayerPrefs.SetInt("come3", Comepleted[2]);
        PlayerPrefs.SetInt("come4", Comepleted[3]);
        PlayerPrefs.SetInt("come5", Comepleted[4]);
        PlayerPrefs.SetInt("come6", Comepleted[5]);
        PlayerPrefs.SetInt("come7", Comepleted[6]);
        PlayerPrefs.SetInt("come8", Comepleted[7]);
        PlayerPrefs.SetInt("come9", Comepleted[8]);
        PlayerPrefs.SetInt("come10", Comepleted[9]);
        PlayerPrefs.SetInt("come11", Comepleted[10]);
        PlayerPrefs.SetInt("come12", Comepleted[11]);
        PlayerPrefs.SetInt("come13", Comepleted[12]);
        PlayerPrefs.SetInt("come14", Comepleted[13]);
        PlayerPrefs.SetInt("come15", Comepleted[14]);
        PlayerPrefs.SetInt("come16", Comepleted[15]);
        PlayerPrefs.SetInt("come17", Comepleted[16]);
        PlayerPrefs.SetInt("come18", Comepleted[17]);
        PlayerPrefs.SetInt("come19", Comepleted[18]);
        PlayerPrefs.SetInt("come20", Comepleted[19]);
        PlayerPrefs.SetInt("come21", Comepleted[20]);
        PlayerPrefs.SetInt("come22", Comepleted[21]);
        PlayerPrefs.SetInt("come23", Comepleted[22]);
        PlayerPrefs.SetInt("come24", Comepleted[23]);
        PlayerPrefs.SetInt("come25", Comepleted[24]);
        PlayerPrefs.SetInt("come26", Comepleted[25]);
        PlayerPrefs.SetInt("come27", Comepleted[26]);
        PlayerPrefs.SetInt("come28", Comepleted[27]);
        PlayerPrefs.SetInt("come29", Comepleted[28]);
        PlayerPrefs.SetInt("come30", Comepleted[29]);

        AllStarsTrackBG.text = "X" + AllStars;
        AllStarsTrack.text = "X" + AllStars;
    }

    public void UnlockStageOne() 
    {
        if (AllStars >= Plus)
        {
            saveUnlockedStage[0] = 1;
            AllStars = AllStars - Plus;
            Plus = Plus + 1;
        }
        else 
        {
            Instantiate(NotEnoughtStars[0], ButtonPos[0]);
            NotEnoughtStars[0].SetActive(true);
        }
    }

    public void UnlockStageTwo() 
    {
        if (AllStars >= Plus)
        {
            saveUnlockedStage[0] = 1;
            AllStars = AllStars - Plus;
            Plus = Plus + 1;
        }
        else
        {
            Instantiate(NotEnoughtStars[1], ButtonPos[1]);
            NotEnoughtStars[1].SetActive(true);
        }
    }
}
