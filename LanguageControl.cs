using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class LanguageControl : MonoBehaviour
{
    public Text uroven;
    public Text[] Menyat;
    public Font fonts;
    public Text[] Won;
    public Text[] Loose;
    public Text[] Replay;
    public Text[] Help;

    public void Awake()
    {
        for (int i = 0; i < Menyat.Length; i++)
        {
            Menyat[i].font = fonts;
        }
        for (int i = 0; i < Won.Length; i++)
        {
            Won[i].font = fonts;
        }
        for (int i = 0; i < Loose.Length; i++)
        {
             Loose[i].font = fonts;
        }
        for (int i = 0; i < Replay.Length; i++)
        {
            Replay[i].font = fonts;
        }
        for (int i = 0; i < Help.Length; i++)
        {
            Help[i].font = fonts;
        }
        if (Application.systemLanguage == SystemLanguage.Russian)
        {
            for (int i = 0; i < LevelSystem.LevelSelected; i++)
            {
                if (LevelSystem.LevelSelected == i)
                {
                    uroven.text = $"Уровень {LevelSystem.LevelSelected}";
                }
                else
                {
                    uroven.text = $"LVL {ReplayScript.SelectReplayLevel}";
                }
            }
            


            Menyat[0].text = "НАЧАТЬ";
            Menyat[1].text = "НАЧАТЬ";
            Menyat[2].text = "ПРОДОЛЖИТЬ";
            Menyat[3].text = "ПРОДОЛЖИТЬ";
            Menyat[4].text = "ГЛАВНОЕ МЕНЮ";
            Menyat[5].text = "ГЛАВНОЕ МЕНЮ";
            Menyat[6].text = "ПЕРЕЗАПУСТИТЬ";
            Menyat[7].text = "ПЕРЕЗАПУСТИТЬ";
            Menyat[8].text = "НАСТРОЙКИ";
            Menyat[9].text = "НАСТРОЙКИ";
            Menyat[10].text = "ВЫЙТИ";
            Menyat[11].text = "ВЫЙТИ";
            Menyat[12].text = "НАСТРОЙКИ";
            Menyat[13].text = "НАСТРОЙКИ";
            Menyat[14].text = "УДВОИТЬ?";
            Menyat[15].text = "УДВОИТЬ?";
            Menyat[16].text = "ДА";
            Menyat[17].text = "ДА";
            Menyat[18].text = "НЕТ";
            Menyat[19].text = "НЕТ";
            Menyat[20].text = "ПРОВЕРЬТЕ СОЕДИНЕНИЕ К ИНТЕРНЕТУ";
            Menyat[21].text = "ПРОВЕРЬТЕ СОЕДИНЕНИЕ К ИНТЕРНЕТУ";

            //////////////////////////////////////////////////////

            Won[0].text = "ПОБЕДА!";
            Won[1].text = "ПОБЕДА!";
            Won[2].text = "СЛЕДУЮЩИЙ";
            Won[3].text = "СЛЕДУЮЩИЙ";
            Won[4].text = "Переиграть";
            Won[5].text = "ПЕРЕИГРАТЬ";
            Won[6].text = "Меню";
            Won[7].text = "Меню";

            //////////////////////////////////////////////////////

            Loose[0].text = "ПРОИГРАЛ";
            Loose[1].text = "ПРОИГРАЛ";
            Loose[2].text = "ПЕРЕИГРАТЬ";
            Loose[3].text = "ПЕРЕИГРАТЬ";
            Loose[4].text = "МЕНЮ";
            Loose[5].text = "МЕНЮ";

            //////////////////////////////////////////////////////

            Replay[0].text = "ПОБЕДА!";
            Replay[1].text = "ПОБЕДА!";
            Replay[2].text = "Переиграть";
            Replay[3].text = "ПЕРЕИГРАТЬ";
            Replay[4].text = "Меню";
            Replay[5].text = "Меню";

            //////////////////////////////////////////////////////

            Help[0].text = "ПОДСКАЗКА ЗА 5 ЗВЕЗД";
            Help[1].text = "ПОДСКАЗКА ЗА 5 ЗВЕЗД";
            Help[2].text = "ЗАКРЫТЬ";
            Help[3].text = "ЗАКРЫТЬ";
            Help[4].text = "ПОСМОТРЕТЬ РЕКЛАМУ И ПОЛУЧИТЬ ПОДСКАЗКУ";
            Help[5].text = "ПОСМОТРЕТЬ РЕКЛАМУ И ПОЛУЧИТЬ ПОДСКАЗКУ";
            Help[6].text = "ЗАКРЫТЬ";
            Help[7].text = "ЗАКРЫТЬ";

        }

        if(Application.systemLanguage == SystemLanguage.English) 
        {
            Menyat[0].text = "START";
            Menyat[1].text = "START";
            for (int i = 0; i < LevelSystem.LevelSelected; i++)
            {
                if (LevelSystem.LevelSelected == i)
                {
                    uroven.text = $"LVL {LevelSystem.LevelSelected}";
                }
                else 
                {
                    uroven.text = $"LVL {ReplayScript.SelectReplayLevel}";
                }
            }
            Menyat[2].text = "RESUME";
            Menyat[3].text = "RESUME";
            Menyat[4].text = "MENU";
            Menyat[5].text = "MENU";
            Menyat[6].text = "RESTART";
            Menyat[7].text = "RESTART";
            Menyat[8].text = "OPTIONS";
            Menyat[9].text = "OPTIONS";
            Menyat[10].text = "EXIT";
            Menyat[11].text = "EXIT";
            Menyat[12].text = "OPTIONS";
            Menyat[13].text = "OPTIONS";
            Menyat[14].text = "DOUBLE?";
            Menyat[15].text = "DOUBLE?";
            Menyat[16].text = "YES";
            Menyat[17].text = "YES";
            Menyat[18].text = "NO";
            Menyat[19].text = "NO";
            Menyat[20].text = "CHECK YOUR CONNECT TO INTERNET";
            Menyat[21].text = "CHECK YOUR CONNECT TO INTERNET   ";

            //////////////////////////////////////////////////////
           

        }

        if (Application.systemLanguage == SystemLanguage.Korean)
        {
            Menyat[0].text = "스타트";
            Menyat[1].text = "스타트";
            for (int i = 0; i < LevelSystem.LevelSelected; i++)
            {
                if (LevelSystem.LevelSelected == i)
                {
                    uroven.text = $"레벨 {LevelSystem.LevelSelected}";
                }
                else
                {
                    uroven.text = $"LVL {ReplayScript.SelectReplayLevel}";
                }
            }
            Menyat[2].text = "계속하다";
            Menyat[3].text = "계속하다";
            Menyat[4].text = "메인 메뉴";
            Menyat[5].text = "메인 메뉴";
            Menyat[6].text = "재시작";
            Menyat[7].text = "재시작";
            Menyat[8].text = "설정";
            Menyat[9].text = "설정";
            Menyat[10].text = "나가";
            Menyat[11].text = "나가";
            Menyat[12].text = "설정";
            Menyat[13].text = "설정";
            Menyat[14].text = "더블?";
            Menyat[15].text = "더블?";
            Menyat[16].text = "예";
            Menyat[17].text = "예";
            Menyat[18].text = "아니";
            Menyat[19].text = "아니";
            Menyat[20].text = "인터넷 연결 확인";
            Menyat[21].text = "인터넷 연결 확인";

            //////////////////////////////////////////////////////

        }

        if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
        {
            Menyat[0].text = "开始";
            Menyat[1].text = "开始";
            for (int i = 0; i < LevelSystem.LevelSelected; i++)
            {
                if (LevelSystem.LevelSelected == i)
                {
                    uroven.text = $"{LevelSystem.LevelSelected}级";
                }
                else
                {
                    uroven.text = $"LVL {ReplayScript.SelectReplayLevel}";
                }
            }
            Menyat[2].text = "继续";
            Menyat[3].text = "继续";
            Menyat[4].text = "主菜单";
            Menyat[5].text = "主菜单";
            Menyat[6].text = "重新开始";
            Menyat[7].text = "重新开始";
            Menyat[8].text = "设定值";
            Menyat[9].text = "设定值";
            Menyat[10].text = "出去";
            Menyat[11].text = "出去";
            Menyat[12].text = "设定值";
            Menyat[13].text = "设定值";
            Menyat[14].text = "双?";
            Menyat[15].text = "双?";
            Menyat[16].text = "是";
            Menyat[17].text = "是";
            Menyat[18].text = "没有";
            Menyat[19].text = "没有";
            Menyat[20].text = "检查您的互联网连接";
            Menyat[21].text = "检查您的互联网连接";

            //////////////////////////////////////////////////////

        }
        if (Application.systemLanguage == SystemLanguage.German)
        {
            Menyat[0].text = "START";
            Menyat[1].text = "START";
            for (int i = 0; i < LevelSystem.LevelSelected; i++)
            {
                if (LevelSystem.LevelSelected == i)
                {
                    uroven.text = $"LVL{LevelSystem.LevelSelected}";
                }
                else
                {
                    uroven.text = $"LVL {ReplayScript.SelectReplayLevel}";
                }
            }
            Menyat[2].text = "fortfahren";
            Menyat[3].text = "fortfahren";
            Menyat[4].text = "Hauptmenü";
            Menyat[5].text = "Hauptmenü";
            Menyat[6].text = "Neu starten";
            Menyat[7].text = "Neu starten";
            Menyat[8].text = "Wert einstellen";
            Menyat[9].text = "Wert einstellen";
            Menyat[10].text = "Hinausgehen";
            Menyat[11].text = "Hinausgehen";
            Menyat[12].text = "Wert einstellen";
            Menyat[13].text = "Wert einstellen";
            Menyat[14].text = "doppelt?";
            Menyat[15].text = "doppelt?";
            Menyat[16].text = "Ja";
            Menyat[17].text = "Ja";
            Menyat[18].text = "Nein";
            Menyat[19].text = "Nein";
            Menyat[20].text = "Prüfe deine Internetverbindung";
            Menyat[21].text = "Prüfe deine Internetverbindung";

            //////////////////////////////////////////////////////

        }
    }
}
