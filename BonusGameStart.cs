using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGameStart : MonoBehaviour
{
    public GameObject[] BonusGames;

    public void Start()
    {
        Debug.Log(BonusGameSelect.SelectedLeaderGame);

        BonusGameSelect.SelectedLeaderGame = PlayerPrefs.GetInt("SelectedLeaderGame");
        for (int i = 0; i < BonusGames.Length; i++)
        {
            if (BonusGameSelect.SelectedLeaderGame == i)
            {
                Instantiate(BonusGames[i], transform.position, Quaternion.identity);
            }
        }
    }
}
