using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerate : MonoBehaviour
{
    [SerializeField]public GameObject[] Levels;

    public void Start()
    {
        ReplayScript.yeswanna = PlayerPrefs.GetInt("AGUSHA");

        if (ReplayScript.yeswanna == 1)
        {
            for (int i = 0; i < Levels.Length; i++)
            {
                if (ReplayScript.SelectReplayLevel == i)
                {
                    Instantiate(Levels[i], transform.position, Quaternion.identity);
                }
            }
        }
        else 
        {
            for (int i = 0; i < Levels.Length; i++)
            {
                if (LevelSystem.LevelSelected == i)
                {
                    Instantiate(Levels[i], transform.position, Quaternion.identity);
                }
            }
        }

        Debug.Log(LevelSystem.LevelSelected);
        Debug.Log(ReplayScript.SelectReplayLevel);
    }
}
