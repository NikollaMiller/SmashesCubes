using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public static int LevelSelected;

    public void Start()
    {
        LevelSelected = PlayerPrefs.GetInt("Lvls");
    }

    public void Update()
    {
        PlayerPrefs.SetInt("Lvls",LevelSelected);
    }

    public void Lvl1() 
    {
        LevelSelected = 1;
    }

    public void Lvl2()
    {
        LevelSelected = 2;
    }

    public void Lvl3()
    {
        LevelSelected = 3;
    }

    public void Lvl4()
    {
        LevelSelected = 4;
    }

    public void Lvl5()
    {
        LevelSelected = 5;
    }

    public void Lvl6()
    {
        LevelSelected = 6;
    }

    public void Lvl7()
    {
        LevelSelected = 7;
    }

    public void Lvl8()
    {
        LevelSelected = 8;
    }

    public void Lvl9()
    {
        LevelSelected = 9;
    }

    public void Lvl10()
    {
        LevelSelected = 10;
    }

    public void Lvl11()
    {
        LevelSelected = 11;
    }

    public void Lvl12()
    {
        LevelSelected = 12;
    }

    public void Lvl13()
    {
        LevelSelected = 13;
    }

    public void Lvl14()
    {
        LevelSelected = 14;
    }
    public void Lvl15()
    {
        LevelSelected = 15;
    }

    public void Lvl16()
    {
        LevelSelected = 16;
    }

    public void Lvl17()
    {
        LevelSelected = 17;
    }

    public void Lvl18()
    {
        LevelSelected = 18;
    }

    public void Lvl19()
    {
        LevelSelected = 19;
    }

    public void Lvl20()
    {
        LevelSelected = 20;
    }

    public void Lvl21()
    {
        LevelSelected = 21;
    }

    public void Lvl22()
    {
        LevelSelected = 22;
    }

    public void Lvl23()
    {
        LevelSelected = 23;
    }

    public void Lvl24()
    {
        LevelSelected = 24;
    }

    public void Lvl25()
    {
        LevelSelected = 25;
    }

    public void Lvl26()
    {
        LevelSelected = 26;
    }

    public void Lvl27()
    {
        LevelSelected = 27;
    }

    public void Lvl28()
    {
        LevelSelected = 28;
    }

    public void Lvl29()
    {
        LevelSelected = 29;
    }

    public void Lvl30()
    {
        LevelSelected = 30;
    }
}
