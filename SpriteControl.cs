using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class SpriteControl : MonoBehaviour
{
    public MeshRenderer[] meshtheme;
    public Material[] materials;
    public Image[] SwipeMenuTheme;
    public Sprite[] MenuThemeOrange;
    public Sprite[] MenuThemeRed;
    public Sprite[] MenuthemeDefault;

    private int replayed;

    public Text levlCount;
    public Text levlCountBG;

    public Font[] fnts;

    public void Start()
    {
        if (Application.systemLanguage == SystemLanguage.Japanese)
        {
            levlCount.text = "リプレイレベル " + replayed;
            levlCountBG.text = "リプレイレベル " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
        else if (Application.systemLanguage == SystemLanguage.Russian) 
        {
            levlCount.text = "УРОВЕНЬ ДЛЯ ПЕРЕИГРЫВАНИЯ " + replayed;
            levlCountBG.text = "УРОВЕНЬ ДЛЯ ПЕРЕИГРЫВАНИЯ " + replayed;
            levlCount.font = fnts[0];
            levlCountBG.font = fnts[0];

        }
        else if (Application.systemLanguage == SystemLanguage.Korean)
        {
            levlCount.text = "레벨 재생 " + replayed;
            levlCountBG.text = "레벨 재생 " +replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
        else if (Application.systemLanguage == SystemLanguage.English)
        {
            levlCount.text = "REPLAY LVL " + replayed;
            levlCountBG.text = "REPLAY LVL " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
    }

    public void Update()
    {
        if (Application.systemLanguage == SystemLanguage.Japanese)
        {
            levlCount.text = "リプレイレベル " + replayed;
            levlCountBG.text = "リプレイレベル " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
        else if (Application.systemLanguage == SystemLanguage.Russian)
        {
            levlCount.text = "УРОВЕНЬ ДЛЯ ПЕРЕИГРЫВАНИЯ " + replayed;
            levlCountBG.text = "УРОВЕНЬ ДЛЯ ПЕРЕИГРЫВАНИЯ " + replayed;
            levlCount.font = fnts[0];
            levlCountBG.font = fnts[0];

        }
        else if (Application.systemLanguage == SystemLanguage.Korean)
        {
            levlCount.text = "레벨 재생 " + replayed;
            levlCountBG.text = "레벨 재생 " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
        else if (Application.systemLanguage == SystemLanguage.English)
        {
            levlCount.text = "REPLAY LVL " + replayed;
            levlCountBG.text = "REPLAY LVL " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }

        if (LevelSystem.LevelSelected >= 11)
        {
            for (int i = 0; i < meshtheme.Length; i++)
            {
                meshtheme[i].material = materials[0];
            }
            for (int i = 0; i < SwipeMenuTheme.Length; i++)
            {
                SwipeMenuTheme[i].sprite = MenuThemeOrange[i];
            }
        }
        if (LevelSystem.LevelSelected >= 21)
        {
            for (int i = 0; i < meshtheme.Length; i++)
            {
                meshtheme[i].material = materials[1];
            }
            for (int i = 0; i < SwipeMenuTheme.Length; i++)
            {
                SwipeMenuTheme[i].sprite = MenuThemeRed[i];
            }
        }
        if (LevelSystem.LevelSelected < 11)
        {
            for (int i = 0; i < meshtheme.Length; i++)
            {
                meshtheme[i].material = materials[2];
            }
            for (int i = 0; i < SwipeMenuTheme.Length; i++)
            {
                SwipeMenuTheme[i].sprite = MenuthemeDefault[i];
            }
        }
    }



    public void S1()
    {
        replayed = 1;
    }

    public void S2()
    {
        replayed = 2;
    }

    public void S3()
    {
        replayed = 3;
    }

    public void S4()
    {
        replayed = 4;
    }

    public void S5()
    {
        replayed = 5;
    }

    public void S6()
    {
        replayed = 6;
    }

    public void S7()
    {
        replayed = 7;
    }

    public void S8()
    {
        replayed = 8;
    }

    public void S9()
    {
        replayed = 9;
    }

    public void S10()
    {
        replayed = 10;
    }

    public void S11()
    {
        replayed = 11;
    }

    public void S12()
    {
        replayed = 12;
    }

    public void S13()
    {
        replayed = 13;
    }

    public void S14()
    {
        replayed = 14;
    }

    public void S15()
    {
        replayed = 15;
    }

    public void S16()
    {
        replayed = 16;
    }

    public void S17()
    {
        replayed = 17;
    }

    public void S18()
    {
        replayed = 18;
    }

    public void S19()
    {
        replayed = 19;
    }

    public void S20()
    {
        replayed = 20;
    }

    public void S21()
    {
        replayed = 21;
    }

    public void S22()
    {
        replayed = 22;
    }

    public void S23()
    {
        replayed = 23;
    }

    public void S24()
    {
        replayed = 24;
    }

    public void S25()
    {
        replayed = 25;
    }

    public void S26()
    {
        replayed = 26;
    }

    public void S27()
    {
        replayed = 27;
    }

    public void S28()
    {
        replayed = 28;
    }

    public void S29()
    {
        replayed = 29;
    }

    public void S30()
    {
        replayed = 30;
    }
}
