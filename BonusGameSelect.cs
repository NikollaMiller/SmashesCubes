using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class BonusGameSelect : MonoBehaviour
{
    [SerializeField] private GameObject bonusGameStoreBar;
    public Text Timer;
    public GameObject PlayWindow;
    public Text[] BonusGames;
    public Animator BonusGamePoyv;
    public Animator PlayWindowAn;
    public Animator storeBtn;
    public GameObject StoreBtnka;
    public GameObject DontPlay;

    private int Minute = 3;
    private float PodMinutes = 59;
    private int x;
    private int Played;
    public static int SelectedLeaderGame;

    public void Start()
    {
        Debug.Log(Played);
        SelectedLeaderGame = PlayerPrefs.GetInt("SelectedLeaderGame");
        PodMinutes = PlayerPrefs.GetFloat("PodMinutes");
        Played = PlayerPrefs.GetInt("YesPlaued");
        Minute = PlayerPrefs.GetInt("Minute");
    }

    public void Update()
    {
        PlayerPrefs.SetInt("SelectedLeaderGame", SelectedLeaderGame);
        PlayerPrefs.SetFloat("PodMinutes",PodMinutes);
        PlayerPrefs.SetInt("YesPlaued", Played);
        PlayerPrefs.SetInt("Minute", Minute);
        if (Played == 1)
        {
            DontPlay.SetActive(true);
            PodMinutes -= 1 * Time.deltaTime;
            x = Convert.ToInt32(PodMinutes);
            if (x <= 0) 
            {
                PodMinutes = 59;
                Minute -= 1;
            }
            else if (x < 10)
            {
                Timer.text = "0" + Minute + ":" + "0" + x;
            }
            else 
            {
                Timer.text = "0"+ Minute + ":" + x;
            }

            if (Minute <= 0) 
            {
                Minute = 3;
                PodMinutes = 59;
                Played = 0;
            }
        }
        else 
        {
            DontPlay.SetActive(false);
            Timer.text = "";
        }
        if (Application.systemLanguage == SystemLanguage.Russian)
        {
            BonusGames[3].text = "СОРЕВНОВАТЕЛЬНЫЕ ИГРЫ";
            BonusGames[4].text = "СОРЕВНОВАТЕЛЬНЫЕ ИГРЫ";
            BonusGames[1].text = "ИГРАТЬ";
            BonusGames[2].text = "НЕТ";
        }
        else if (Application.systemLanguage == SystemLanguage.German)
        {
            BonusGames[3].text = "WETTBEWERBSSPIELE";
            BonusGames[4].text = "WETTBEWERBSSPIELE";
            BonusGames[1].text = "ABSPIELEN";
            BonusGames[2].text = "NEIN";
        }
        else if (Application.systemLanguage == SystemLanguage.Korean)
        {
            BonusGames[3].text = "경쟁 게임";
            BonusGames[4].text = "경쟁 게임";
            BonusGames[1].text = "플레이";
            BonusGames[2].text = "아니";
        }
        else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
        {
            BonusGames[3].text = "競技遊戲";
            BonusGames[4].text = "競技遊戲";
            BonusGames[1].text = "玩";
            BonusGames[2].text = "沒有";
        }
        else
        {
            BonusGames[3].text = "COMPETITIVE GAMEs";
            BonusGames[4].text = "COMPETITIVE GAMEs";
            BonusGames[1].text = "PLAY";
            BonusGames[2].text = "NO";
        }
    }

    public void OpenBonusLeader() 
    {
        BonusGamePoyv.SetInteger("bnska",0);
        storeBtn.SetInteger("ShopBtnki", 1);
        Invoke("TurnOffBtn",1);
    }

    private void TurnOffBtn() { StoreBtnka.SetActive(false); bonusGameStoreBar.SetActive(true); }

    public void CloseStore() 
    {
        storeBtn.SetInteger("ShopBtnki", 0);
        BonusGamePoyv.SetInteger("bnska", 1);
        Invoke("TurnOffStore",1);
    }

    private void TurnOffStore() 
    {
        StoreBtnka.SetActive(true);
        bonusGameStoreBar.SetActive(false);
    }

    public void SelectLeaderGame(int game)
    {
        if (game == 0)
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                BonusGames[0].text = "Падение";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                BonusGames[0].text = "Fallende Würfel";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                BonusGames[0].text = "떨어지는 큐브";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                BonusGames[0].text = "下降的多維數據集";
            }
            else
            {
                BonusGames[0].text = "";
            }
        }
        else if (game == 1)
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                BonusGames[0].text = "Гонка";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                BonusGames[0].text = "Rennen";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                BonusGames[0].text = "경주";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                BonusGames[0].text = "種族";
            }
            else
            {
                BonusGames[0].text = "RACE";
            }
        }
        else if (game == 2)
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                BonusGames[0].text = "НАЙТИ ВЫХОД";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                BonusGames[0].text = "Finden Sie den Ausweg";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                BonusGames[0].text = "탈출구 찾기";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                BonusGames[0].text = "尋找出路";
            }
            else
            {
                BonusGames[0].text = "FInd Exit";
            }
        }
        else if (game == 3) 
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                BonusGames[0].text = "ПРЫГАЙ ЧТОБЫ СПАСТИСЬ";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                BonusGames[0].text = "SPRINGEN, UM ZU SPAREN";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                BonusGames[0].text = "저장하려면 이동";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                BonusGames[0].text = "跳轉保存";
            }
            else
            {
                BonusGames[0].text = "Jump to save yourself";
            }
        }
        Played = 1;
     
        SelectedLeaderGame = game;
        PlayWindow.SetActive(true);
        PlayWindowAn.SetInteger("winkawonka",0);
    }

    public void CloseWindowOfPlay() 
    {
        PlayWindowAn.SetInteger("winkawonka",1);
        Invoke("CloseWindow", 1);
    }

    private void CloseWindow() 
    {
        PlayWindow.SetActive(false);
    }
    public void PlaySelected() 
    {
        SceneManager.LoadScene(3);
    }

    public void NotPlay() 
    {

    }
}
