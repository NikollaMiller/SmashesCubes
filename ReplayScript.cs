using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReplayScript : MonoBehaviour
{
    public static int SelectReplayLevel;
    public static int[] StarsForReplay = new int[30];

    public Text StarPerLevel;
    public Text StarPerLevelBG;

    public spuk spak;

    public GameObject replayBar;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;

    public void Start()
    {
        SelectReplayLevel = PlayerPrefs.GetInt("Selected");
        StarsForReplay[0] = PlayerPrefs.GetInt("Replaing1", StarsForReplay[0]);
        StarsForReplay[1] = PlayerPrefs.GetInt("Replaing2", StarsForReplay[1]);
        StarsForReplay[2] = PlayerPrefs.GetInt("Replaing3", StarsForReplay[2]);
        StarsForReplay[3] = PlayerPrefs.GetInt("Replaing4", StarsForReplay[3]);
        StarsForReplay[4] = PlayerPrefs.GetInt("Replaing5", StarsForReplay[4]);
        StarsForReplay[5] = PlayerPrefs.GetInt("Replaing6", StarsForReplay[5]);
        StarsForReplay[6] = PlayerPrefs.GetInt("Replaing7", StarsForReplay[6]);
        StarsForReplay[7] = PlayerPrefs.GetInt("Replaing8", StarsForReplay[7]);
        StarsForReplay[8] = PlayerPrefs.GetInt("Replaing9", StarsForReplay[8]);
        StarsForReplay[9] = PlayerPrefs.GetInt("Replaing10", StarsForReplay[9]);
        StarsForReplay[10] = PlayerPrefs.GetInt("Replaing11", StarsForReplay[10]);
        StarsForReplay[11] = PlayerPrefs.GetInt("Replaing12", StarsForReplay[11]);
        StarsForReplay[12] = PlayerPrefs.GetInt("Replaing13", StarsForReplay[12]);
        StarsForReplay[13] = PlayerPrefs.GetInt("Replaing14", StarsForReplay[13]);
        StarsForReplay[14] = PlayerPrefs.GetInt("Replaing15", StarsForReplay[14]);
        StarsForReplay[15] = PlayerPrefs.GetInt("Replaing16", StarsForReplay[15]);
        StarsForReplay[16] = PlayerPrefs.GetInt("Replaing17", StarsForReplay[16]);
        StarsForReplay[17] = PlayerPrefs.GetInt("Replaing18", StarsForReplay[17]);
        StarsForReplay[18] = PlayerPrefs.GetInt("Replaing19", StarsForReplay[18]);
        StarsForReplay[19] = PlayerPrefs.GetInt("Replaing20", StarsForReplay[19]);
        StarsForReplay[20] = PlayerPrefs.GetInt("Replaing21", StarsForReplay[20]);
        StarsForReplay[21] = PlayerPrefs.GetInt("Replaing22", StarsForReplay[21]);
        StarsForReplay[22] = PlayerPrefs.GetInt("Replaing23", StarsForReplay[22]);
        StarsForReplay[23] = PlayerPrefs.GetInt("Replaing24", StarsForReplay[23]);
        StarsForReplay[24] = PlayerPrefs.GetInt("Replaing25", StarsForReplay[24]);
        StarsForReplay[25] = PlayerPrefs.GetInt("Replaing26", StarsForReplay[25]);
        StarsForReplay[26] = PlayerPrefs.GetInt("Replaing27", StarsForReplay[26]);
        StarsForReplay[27] = PlayerPrefs.GetInt("Replaing28", StarsForReplay[27]);
        StarsForReplay[28] = PlayerPrefs.GetInt("Replaing29", StarsForReplay[28]);
        StarsForReplay[29] = PlayerPrefs.GetInt("Replaing30", StarsForReplay[29]);
    }

    public void Update()
    {
        PlayerPrefs.SetInt("Selected", SelectReplayLevel);
        if (SelectReplayLevel == 1 && StarsForReplay[0] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[0] + "/3";
            StarPerLevelBG.text = StarsForReplay[0] + "/3";
        }

        if (SelectReplayLevel == 1 && StarsForReplay[0] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[0] + "/3";
            StarPerLevelBG.text = StarsForReplay[0] + "/3";
        }

        if (SelectReplayLevel == 1 && StarsForReplay[0] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[0] + "/3";
            StarPerLevelBG.text = StarsForReplay[0] + "/3";
        }

        if (SelectReplayLevel == 1 && StarsForReplay[0] == 4)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[0] + "/3";
            StarPerLevelBG.text = StarsForReplay[0] + "/3";
        }

        if (SelectReplayLevel == 2 && StarsForReplay[1] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[1] + "/3";
            StarPerLevelBG.text = StarsForReplay[1] + "/3";
        }

         if (SelectReplayLevel == 2 && StarsForReplay[1] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[1] + "/3";
            StarPerLevelBG.text = StarsForReplay[1] + "/3";
        }

        if (SelectReplayLevel == 2 && StarsForReplay[1] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[1] + "/3";
            StarPerLevelBG.text = StarsForReplay[1] + "/3";
        }

        if (SelectReplayLevel == 2 && StarsForReplay[1] == 4)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[1] + "/3";
            StarPerLevelBG.text = StarsForReplay[1] + "/3";
        }


        if (SelectReplayLevel == 3 && StarsForReplay[2] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[2] + "/3";
            StarPerLevelBG.text = StarsForReplay[2] + "/3";
        }

         if (SelectReplayLevel == 3 && StarsForReplay[2] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[2] + "/3";
            StarPerLevelBG.text = StarsForReplay[2] + "/3";
        }

         if (SelectReplayLevel == 3 && StarsForReplay[2] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[2] + "/3";
            StarPerLevelBG.text = StarsForReplay[2] + "/3";
        }

        if (SelectReplayLevel == 4 && StarsForReplay[3] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[3] + "/3";
            StarPerLevelBG.text = StarsForReplay[3] + "/3";
        }

         if (SelectReplayLevel == 4 && StarsForReplay[3] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[3] + "/3";
            StarPerLevelBG.text = StarsForReplay[3] + "/3";
        }

        if (SelectReplayLevel == 4 && StarsForReplay[3] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[3] + "/3";
            StarPerLevelBG.text = StarsForReplay[3] + "/3";
        }

        if (SelectReplayLevel == 5 && StarsForReplay[4] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[4] + "/3";
            StarPerLevelBG.text = StarsForReplay[4] + "/3";
        }

        if (SelectReplayLevel == 5 && StarsForReplay[4] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[4] + "/3";
            StarPerLevelBG.text = StarsForReplay[4] + "/3";
        }

         if (SelectReplayLevel == 5 && StarsForReplay[4] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[4] + "/3";
            StarPerLevelBG.text = StarsForReplay[4] + "/3";
        }

         if (SelectReplayLevel == 6 && StarsForReplay[5] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[5] + "/3";
            StarPerLevelBG.text = StarsForReplay[5] + "/3";
        }

         if (SelectReplayLevel == 6 && StarsForReplay[5] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[5] + "/3";
            StarPerLevelBG.text = StarsForReplay[5] + "/3";
        }

        if (SelectReplayLevel == 6 && StarsForReplay[5] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[5] + "/3";
            StarPerLevelBG.text = StarsForReplay[5] + "/3";
        }

        if (SelectReplayLevel == 7 && StarsForReplay[6] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[6] + "/3";
            StarPerLevelBG.text = StarsForReplay[6] + "/3";
        }
         if (SelectReplayLevel == 7 && StarsForReplay[6] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[6] + "/3";
            StarPerLevelBG.text = StarsForReplay[6] + "/3";
        }
         if (SelectReplayLevel == 7 && StarsForReplay[6] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[6] + "/3";
            StarPerLevelBG.text = StarsForReplay[6] + "/3";
        }

         if (SelectReplayLevel == 8 && StarsForReplay[7] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[7] + "/3";
            StarPerLevelBG.text = StarsForReplay[7] + "/3";
        }

         if (SelectReplayLevel == 8 && StarsForReplay[7] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[7] + "/3";
            StarPerLevelBG.text = StarsForReplay[7] + "/3";
        }

         if (SelectReplayLevel == 8 && StarsForReplay[7] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[7] + "/3";
            StarPerLevelBG.text = StarsForReplay[7] + "/3";
        }
         if (SelectReplayLevel == 9 && StarsForReplay[8] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[8] + "/3";
            StarPerLevelBG.text = StarsForReplay[8] + "/3";
        }

         if (SelectReplayLevel == 9 && StarsForReplay[8] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[8] + "/3";
            StarPerLevelBG.text = StarsForReplay[8] + "/3";
        }

        if (SelectReplayLevel == 9 && StarsForReplay[8] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[8] + "/3";
            StarPerLevelBG.text = StarsForReplay[8] + "/3";
        }

         if (SelectReplayLevel == 10 && StarsForReplay[9] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[9] + "/3";
            StarPerLevelBG.text = StarsForReplay[9] + "/3";
        }

         if (SelectReplayLevel == 10 && StarsForReplay[9] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[9] + "/3";
            StarPerLevelBG.text = StarsForReplay[9] + "/3";
        }

        if (SelectReplayLevel == 10 && StarsForReplay[9] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[9] + "/3";
            StarPerLevelBG.text = StarsForReplay[9] + "/3";
        }

        if (SelectReplayLevel == 11 && StarsForReplay[10] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[10] + "/3";
            StarPerLevelBG.text = StarsForReplay[10] + "/3";
        }

         if (SelectReplayLevel == 11 && StarsForReplay[10] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[10] + "/3";
            StarPerLevelBG.text = StarsForReplay[10] + "/3";
        }

         if (SelectReplayLevel == 11 && StarsForReplay[10] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[10] + "/3";
            StarPerLevelBG.text = StarsForReplay[10] + "/3";
        }

         if (SelectReplayLevel == 12 && StarsForReplay[11] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[11] + "/3";
            StarPerLevelBG.text = StarsForReplay[11] + "/3";
        }

         if (SelectReplayLevel == 12 && StarsForReplay[11] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[11] + "/3";
            StarPerLevelBG.text = StarsForReplay[11] + "/3";
        }

         if (SelectReplayLevel == 12 && StarsForReplay[11] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[11] + "/3";
            StarPerLevelBG.text = StarsForReplay[11] + "/3";
        }

         if (SelectReplayLevel == 13 && StarsForReplay[12] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[12] + "/3";
            StarPerLevelBG.text = StarsForReplay[12] + "/3";
        }

         if (SelectReplayLevel == 13 && StarsForReplay[12] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[12] + "/3";
            StarPerLevelBG.text = StarsForReplay[12] + "/3";
        }

        if (SelectReplayLevel == 13 && StarsForReplay[12] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[12] + "/3";
            StarPerLevelBG.text = StarsForReplay[12] + "/3";
        }

         if (SelectReplayLevel == 14 && StarsForReplay[13] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[13] + "/3";
            StarPerLevelBG.text = StarsForReplay[13] + "/3";
        }

         if (SelectReplayLevel == 14 && StarsForReplay[13] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[13] + "/3";
            StarPerLevelBG.text = StarsForReplay[13] + "/3";
        }

         if (SelectReplayLevel == 14 && StarsForReplay[13] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[13] + "/3";
            StarPerLevelBG.text = StarsForReplay[13] + "/3";
        }

         if (SelectReplayLevel == 15 && StarsForReplay[14] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[14] + "/3";
            StarPerLevelBG.text = StarsForReplay[14] + "/3";
        }

        if (SelectReplayLevel == 15 && StarsForReplay[14] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[14] + "/3";
            StarPerLevelBG.text = StarsForReplay[14] + "/3";
        }

         if (SelectReplayLevel == 15 && StarsForReplay[14] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[14] + "/3";
            StarPerLevelBG.text = StarsForReplay[14] + "/3";
        }

         if (SelectReplayLevel == 16 && StarsForReplay[15] == 1 )
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[15] + "/3";
            StarPerLevelBG.text = StarsForReplay[15] + "/3";
        }

         if (SelectReplayLevel == 16 && StarsForReplay[15] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[15] + "/3";
            StarPerLevelBG.text = StarsForReplay[15] + "/3";
        }

        if (SelectReplayLevel == 16 && StarsForReplay[15] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[15] + "/3";
            StarPerLevelBG.text = StarsForReplay[15] + "/3";
        }

        if (SelectReplayLevel == 17 && StarsForReplay[16] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[16] + "/3";
            StarPerLevelBG.text = StarsForReplay[16] + "/3";
        }

         if (SelectReplayLevel == 17 && StarsForReplay[16] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[16] + "/3";
            StarPerLevelBG.text = StarsForReplay[16] + "/3";
        }

         if (SelectReplayLevel == 17 && StarsForReplay[16] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[16] + "/3";
            StarPerLevelBG.text = StarsForReplay[16] + "/3";
        }

        if (SelectReplayLevel == 18 && StarsForReplay[17] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[17] + "/3";
            StarPerLevelBG.text = StarsForReplay[17] + "/3";
        }

        if (SelectReplayLevel == 18 && StarsForReplay[17] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[17] + "/3";
            StarPerLevelBG.text = StarsForReplay[17] + "/3";
        }

        if (SelectReplayLevel == 18 && StarsForReplay[17] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[17] + "/3";
            StarPerLevelBG.text = StarsForReplay[17] + "/3";
        }

         if (SelectReplayLevel == 19 && StarsForReplay[18] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[18] + "/3";
            StarPerLevelBG.text = StarsForReplay[18] + "/3";
        }

        if (SelectReplayLevel == 19 && StarsForReplay[18] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[18] + "/3";
            StarPerLevelBG.text = StarsForReplay[18] + "/3";
        }

        if (SelectReplayLevel == 19 && StarsForReplay[18] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[18] + "/3";
            StarPerLevelBG.text = StarsForReplay[18] + "/3";
        }

        if (SelectReplayLevel == 20 && StarsForReplay[19] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[19] + "/3";
            StarPerLevelBG.text = StarsForReplay[19] + "/3";
        }

        if (SelectReplayLevel == 20 && StarsForReplay[19] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[19] + "/3";
            StarPerLevelBG.text = StarsForReplay[19] + "/3";
        }

        if (SelectReplayLevel == 20 && StarsForReplay[19] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[19] + "/3";
            StarPerLevelBG.text = StarsForReplay[19] + "/3";
        }

        if (SelectReplayLevel == 21 && StarsForReplay[20] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[20] + "/3";
            StarPerLevelBG.text = StarsForReplay[20] + "/3";
        }

        if (SelectReplayLevel == 21 && StarsForReplay[20] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[20] + "/3";
            StarPerLevelBG.text = StarsForReplay[20] + "/3";
        }

        if (SelectReplayLevel == 21 && StarsForReplay[20] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[20] + "/3";
            StarPerLevelBG.text = StarsForReplay[20] + "/3";
        }

        if (SelectReplayLevel == 22 && StarsForReplay[21] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[21] + "/3";
            StarPerLevelBG.text = StarsForReplay[21] + "/3";
        }

        if (SelectReplayLevel == 22 && StarsForReplay[21] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[21] + "/3";
            StarPerLevelBG.text = StarsForReplay[21] + "/3";
        }

        if (SelectReplayLevel == 22 && StarsForReplay[21] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[21] + "/3";
            StarPerLevelBG.text = StarsForReplay[21] + "/3";
        }

        if (SelectReplayLevel == 23 && StarsForReplay[22] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[22] + "/3";
            StarPerLevelBG.text = StarsForReplay[22] + "/3";
        }

        if (SelectReplayLevel == 23 && StarsForReplay[22] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[22] + "/3";
            StarPerLevelBG.text = StarsForReplay[22] + "/3";
        }

        if (SelectReplayLevel == 23 && StarsForReplay[22] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[22] + "/3";
            StarPerLevelBG.text = StarsForReplay[22] + "/3";
        }

        if (SelectReplayLevel == 24 && StarsForReplay[23] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[23] + "/3";
            StarPerLevelBG.text = StarsForReplay[23] + "/3";
        }

        if (SelectReplayLevel == 24 && StarsForReplay[23] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[23] + "/3";
            StarPerLevelBG.text = StarsForReplay[23] + "/3";
        }

        if (SelectReplayLevel == 24 && StarsForReplay[23] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[23] + "/3";
            StarPerLevelBG.text = StarsForReplay[23] + "/3";
        }

        if (SelectReplayLevel == 25 && StarsForReplay[24] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[24] + "/3";
            StarPerLevelBG.text = StarsForReplay[24] + "/3";
        }

         if (SelectReplayLevel == 25 && StarsForReplay[24] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[24] + "/3";
            StarPerLevelBG.text = StarsForReplay[24] + "/3";
        }

        if (SelectReplayLevel == 25 && StarsForReplay[24] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[24] + "/3";
            StarPerLevelBG.text = StarsForReplay[24] + "/3";
        }

         if (SelectReplayLevel == 26 && StarsForReplay[25] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[25] + "/3";
            StarPerLevelBG.text = StarsForReplay[25] + "/3";
        }

         if (SelectReplayLevel == 26 && StarsForReplay[25] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[25] + "/3";
            StarPerLevelBG.text = StarsForReplay[25] + "/3";
        }

         if (SelectReplayLevel == 26 && StarsForReplay[25] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[25] + "/3";
            StarPerLevelBG.text = StarsForReplay[25] + "/3";
        }

         if (SelectReplayLevel == 27 && StarsForReplay[26] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[26] + "/3";
            StarPerLevelBG.text = StarsForReplay[26] + "/3";
        }
         if (SelectReplayLevel == 27 && StarsForReplay[26] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[26] + "/3";
            StarPerLevelBG.text = StarsForReplay[26] + "/3";
        }

         if (SelectReplayLevel == 27 && StarsForReplay[26] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[26] + "/3";
            StarPerLevelBG.text = StarsForReplay[26] + "/3";
        }


         if (SelectReplayLevel == 28 && StarsForReplay[27] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[27] + "/3";
            StarPerLevelBG.text = StarsForReplay[27] + "/3";
        }

         if (SelectReplayLevel == 28 && StarsForReplay[27] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[27] + "/3";
            StarPerLevelBG.text = StarsForReplay[27] + "/3";
        }

         if (SelectReplayLevel == 28 && StarsForReplay[27] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[27] + "/3";
            StarPerLevelBG.text = StarsForReplay[27] + "/3";
        }

         if (SelectReplayLevel == 29 && StarsForReplay[28] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[28] + "/3";
            StarPerLevelBG.text = StarsForReplay[28] + "/3";
        }

        if (SelectReplayLevel == 29 && StarsForReplay[28] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[28] + "/3";
            StarPerLevelBG.text = StarsForReplay[28] + "/3";
        }

         if (SelectReplayLevel == 29 && StarsForReplay[28] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[28] + "/3";
            StarPerLevelBG.text = StarsForReplay[28] + "/3";
        }

         if (SelectReplayLevel == 30 && StarsForReplay[29] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[29] + "/3";
            StarPerLevelBG.text = StarsForReplay[29] + "/3";
        }

         if (SelectReplayLevel == 30 && StarsForReplay[29] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[29] + "/3";
            StarPerLevelBG.text = StarsForReplay[29] + "/3";
        }
         if (SelectReplayLevel == 30 && StarsForReplay[29] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[29] + "/3";
            StarPerLevelBG.text = StarsForReplay[29] + "/3";
        }

    }


    public void SelectForReplayLevelOne()
    {
        SelectReplayLevel = 1;
        replayBar.SetActive(true);
    }

    public void SelectForReplayLevelTwo()
    {
        SelectReplayLevel = 2;
        replayBar.SetActive(true);
    }

    public void SelectForReplayLevelThree()
    {
        SelectReplayLevel = 3;
        replayBar.SetActive(true);
    }

    public void SelectForReplayLevelFour()
    {
        SelectReplayLevel = 4;
        replayBar.SetActive(true);
    }

    public void SelectForReplayLevelFive()
    {
        SelectReplayLevel = 5;
        replayBar.SetActive(true);
    }

    public void SelectForReplayLevelSix()
    {
        SelectReplayLevel = 6;
        replayBar.SetActive(true);
    }

    public void SelectForReplayLevelSeven()
    {
        SelectReplayLevel = 7;
        replayBar.SetActive(true);
    }

    public void SelectForReplayLevelEight()
    {
        SelectReplayLevel = 8;
        replayBar.SetActive(true);
    }

    public void SelectForReplayLevelnine()
    {
        SelectReplayLevel = 9;
    }

    public void SelectForReplayLevelTen()
    {
        SelectReplayLevel = 10;
    }

    public void SelectForReplayLevelEleven()
    {
        SelectReplayLevel = 11;
    }

    public void SelectForReplayLeveltwoeleven()
    {
        SelectReplayLevel = 12;
    }

    public void SelectForReplayLevelThreeLeven()
    {
        SelectReplayLevel = 13;
    }

    public void SelectForReplayLevelFourleven()
    {
        SelectReplayLevel = 14;
    }

    public void SelectForReplayLevelFiveleven()
    {
        SelectReplayLevel = 15;
    }
    public void SelectForReplayLevelSixleven()
    {
        SelectReplayLevel = 16;
    }

    public void SelectForReplayLevelSevenleven()
    {
        SelectReplayLevel = 17;
    }

    public void SelectForReplayLevelEightleven()
    {
        SelectReplayLevel = 18;
    }

    public void SelectForReplayLevelNineleven()
    {
        SelectReplayLevel = 19;
    }

    public void SelectForReplayLevelTwenty()
    {
        SelectReplayLevel = 20;
    }

    public void SelectForReplayLeveltwentyOne()
    {
        SelectReplayLevel = 21;
    }
    public void SelectForReplayLevelTwentyTwo()
    {
        SelectReplayLevel = 22;
    }
    public void SelectForReplayLevelTwentyThree()
    {
        SelectReplayLevel = 23;
    }
    public void SelectForReplayLevelTwentyFour()
    {
        SelectReplayLevel = 24;
    }

    public void SelectForReplayLevelTwentyFive()
    {
        SelectReplayLevel = 25;
    }

    public void SelectForReplayLevelTwentySix()
    {
        SelectReplayLevel = 26;
    }

    public void SelectForReplayLevelTwentySeven()
    {
        SelectReplayLevel = 27;
    }

    public void SelectForReplayLevelTwentyEight()
    {
        SelectReplayLevel = 28;
    }

    public void SelectForReplayLevelTwentyNine()
    {
        SelectReplayLevel = 29;
    }

    public void SelectForReplayLevelThreeTy()
    {
        SelectReplayLevel = 30;
    }


    public void CloseReplayBar() 
    {
        SelectReplayLevel = 0;
    }

    public void SelectReplayLevelOne() 
    {
        if (SelectReplayLevel == 1)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[0];
            StarsForReplay[0] = 0;
            Invoke("odna", 1);
        }
        else if (SelectReplayLevel == 2)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[1];
            Invoke("dvatna", 1);
        }
        else if (SelectReplayLevel == 3)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[2];
            Invoke("odtritnana", 1);
        }
        else if (SelectReplayLevel == 4)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[3];
            Invoke("chetvertna", 1);
        }
        else if (SelectReplayLevel == 5)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[4];
            Invoke("pyatna", 1);
        }
        else if (SelectReplayLevel == 6)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[5];
            Invoke("shestna", 1);
        }
        else if (SelectReplayLevel == 7)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[6];
            Invoke("semna", 1);
        }
        else if (SelectReplayLevel == 8)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[7];
            Invoke("vosyatat", 1);
        }
        else if (SelectReplayLevel == 9)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[8];
            Invoke("devtyat", 1);
        }
        else if (SelectReplayLevel == 10)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[9];
            Invoke("destyat", 1);
        }
        else if (SelectReplayLevel == 11)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[10];
            Invoke("odinatat", 1);
        }
        else if (SelectReplayLevel == 12)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[11];
            Invoke("dvenatat", 1);
        }
        else if (SelectReplayLevel == 13)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[12];
            Invoke("trinatat", 1);
        }
        else if (SelectReplayLevel == 14)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[13];
            Invoke("chetirnatat", 1);
        }
        else if (SelectReplayLevel == 15)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[14];
            Invoke("pyatnatat", 1);
        }
        else if (SelectReplayLevel == 16)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[15];
            Invoke("shestnatat", 1);
        }
        else if (SelectReplayLevel == 17)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[16];
            Invoke("semnadtat", 1);
        }
        else if (SelectReplayLevel == 18)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[17];
            Invoke("vosymnadtat", 1);
        }
        else if (SelectReplayLevel == 19)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[18];
            Invoke("devyatnadtad", 1);
        }
        else if (SelectReplayLevel == 20)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[19];
            Invoke("dvatad", 1);
        }
        else if (SelectReplayLevel == 21)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[20];
            Invoke("dvatodnerka", 1);
        }
        else if (SelectReplayLevel == 22)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[21];
            Invoke("dvatdvoika", 1);
        }
        else if (SelectReplayLevel == 23)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[22];
            Invoke("dvattroika", 1);
        }
        else if (SelectReplayLevel == 24)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[23];
            Invoke("dvatchetverka", 1);
        }
        else if (SelectReplayLevel == 25)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[24];
            Invoke("dvatpyaterka", 1);
        }
        else if (SelectReplayLevel == 26)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[25];
            Invoke("dvatshesterka", 1);
        }
        else if (SelectReplayLevel == 27)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[26];
            Invoke("dvatsemerka", 1);
        }

        else if (SelectReplayLevel == 28)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[27];
            Invoke("dvatvosmerka", 1);
        }
        else if (SelectReplayLevel == 29)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[28];
            Invoke("dvatdevyatka", 1);
        }
        else if (SelectReplayLevel == 30)
        {
            StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[29];
            Invoke("tridka", 1);
        }
        spak.enabled = true;
    }

    private void odna() 
    {
        SceneManager.LoadScene("1");
    }
    private void dvatna()
    {
        SceneManager.LoadScene("2");
    }
    private void odtritnana()
    {
        SceneManager.LoadScene("3");
    }
    private void chetvertna()
    {
        SceneManager.LoadScene("4");
    }
    private void pyatna()
    {
        SceneManager.LoadScene("5");
    }
    private void shestna()
    {
        SceneManager.LoadScene("6");
    }
    private void semna()
    {
        SceneManager.LoadScene("7");
    }
    private void vosyatat()
    {
        SceneManager.LoadScene("8");
    }
    private void devtyat()
    {
        SceneManager.LoadScene("9");
    }
    private void destyat()
    {
        SceneManager.LoadScene("10");
    }
    private void odinatat()
    {
        SceneManager.LoadScene("11");
    }
    private void dvenatat()
    {
        SceneManager.LoadScene("12");
    }
    private void trinatat()
    {
        SceneManager.LoadScene("13");
    }
    private void chetirnatat()
    {
        SceneManager.LoadScene("14");
    }
    private void pyatnatat()
    {
        SceneManager.LoadScene("15");
    }
    private void shestnatat()
    {
        SceneManager.LoadScene("16");
    }
    private void semnadtat()
    {
        SceneManager.LoadScene("17");
    }
    private void vosymnadtat()
    {
        SceneManager.LoadScene("18");
    }
    private void devyatnadtad()
    {
        SceneManager.LoadScene("19");
    }
    private void dvatad()
    {
        SceneManager.LoadScene("20");
    }
    private void dvatodnerka()
    {
        SceneManager.LoadScene("21");
    }
    private void dvatdvoika()
    {
        SceneManager.LoadScene("22");
    }
    private void dvattroika()
    {
        SceneManager.LoadScene("23");
    }
    private void dvatchetverka()
    {
        SceneManager.LoadScene("24");
    }
    private void dvatpyaterka()
    {
        SceneManager.LoadScene("25");
    }
    private void dvatshesterka()
    {
        SceneManager.LoadScene("26");
    }
    private void dvatsemerka()
    {
        SceneManager.LoadScene("27");
    }
    private void dvatvosmerka()
    {
        SceneManager.LoadScene("28");
    }
    private void dvatdevyatka()
    {
        SceneManager.LoadScene("29");
    }
    private void tridka()
    {
        SceneManager.LoadScene("30");
    }

}
