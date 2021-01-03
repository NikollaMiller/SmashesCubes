using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poshalka : MonoBehaviour
{
    public GameObject Authorization;
    public GameObject TopSectretBar;
    public GameObject textofNotCorrect;
    public GameObject passwordik;
    public GameObject Ask;
    public GameObject Passwordic;
    public GameObject[] voted;
    public GameObject Zabub;
    public GameObject BezBub;

    public Animator[] voterik;
    public Animator[] closes;

    public Text[] Menu;
    public Text[] topsecret;
    //public Text[] Levels;

    public InputField password;
    public InputField Name;

    public Transform notcorrectPassword;

    // public Sprite[] sprites;
    //public SpriteRenderer[] menyat;

    public int kit;
    private int[] YesOrNo = new int[4];
    private int SkipQs;


    public void Start()
    {
        Debug.Log(SkipQs);
        kit = PlayerPrefs.GetInt("kit", kit);
        SkipQs = PlayerPrefs.GetInt("SkipbQs", SkipQs);
    }

    public void Update()
    {
        PlayerPrefs.SetInt("SkipbQs", SkipQs);
        if (SkipQs == 1)
        {
            Passwordic.SetActive(false);
            passwordik.SetActive(true);
            Ask.SetActive(false);
        }
        if (kit == 1)
        {
            Menu[0].text = "ЖИЖУ ЗАЛИВАЙ";
            Menu[1].text = "ЖИЖУ ЗАЛИВАЙ";
        }
        if (kit == 2)
        {
            Menu[0].text = "АКОРД ЕМ";
            Menu[1].text = "АКОРД ЕМ";
        }
        if (kit == 3)
        {
            Menu[0].text = "ДАВАЙ СДЕЛАЕМ ИГРУ";
            Menu[1].text = "ДАВАЙ СДЕЛАЕМ ИГРУ";
        }
        if (kit == 4)
        {
            Menu[0].text = "ЛСП";
            Menu[1].text = "ЛСП";
        }
        PlayerPrefs.SetInt("kit", kit);

    }

    public void ZaBAB()
    {
        if (YesOrNo[0] == 1)
        {

        }
        else
        {

        }
    }

    public void BezBab()
    {
        if (YesOrNo[1] == 1)
        {

        }
        else
        {

        }
    }

    public void TopSectretBarOpen()
    {
        Authorization.SetActive(true);
    }

    public void SumbitQuestion()
    {
        TopSectretBar.SetActive(true);
        Ask.SetActive(false);
        Debug.Log(SkipQs);
        SkipQs = 1;
    }

    public void buttonSubmitAfter() 
    {
        if (Name.text == "#BEZ_BAB" && SkipQs == 1)
        {
            TopSectretBar.SetActive(true);
            passwordik.SetActive(false);
            Passwordic.SetActive(false);
            Ask.SetActive(false);
        }
        else
        {
            textofNotCorrect.SetActive(true);
            var cell = Instantiate(textofNotCorrect, notcorrectPassword);
            cell.transform.localPosition = new Vector3(0, 0, 0);
            Invoke("dontshow", 0.4f);
        }
    } 

    public void buttonSubmit()
    {
        if (password.text == "#BEZ_BAB")
        {
            Ask.SetActive(true);   
            Passwordic.SetActive(false);
        }
        else
        {
            textofNotCorrect.SetActive(true);
            var cell = Instantiate(textofNotCorrect, notcorrectPassword);
            cell.transform.localPosition = new Vector3(0, 0, 0);
            Invoke("dontshow", 0.4f);
        }
    }

    private void dontshow()
    {
        textofNotCorrect.SetActive(false);
    }

    private void Cllose() 
    {
        voted[1].SetActive(false);
    }

    private void Close() 
    {
        voted[0].SetActive(false);
    }

    private void Cllose2()
    {
        voted[3].SetActive(false);
    }

    private void Close2()
    {
        voted[2].SetActive(false);
    }
    public void VoteYesFirst()
    {
        for (int i = 0; i < YesOrNo.Length; i++)
        {
            Debug.Log(YesOrNo[i]);
        }
        YesOrNo[0] = 1;
        YesOrNo[1] = 0;
        voted[0].SetActive(true);
        voterik[1].SetInteger("Votesik", 1);
        Invoke("Cllose",1);
    }
    public void VoteNoFirst()
    {
        for (int i = 0; i < YesOrNo.Length; i++)
        {
            Debug.Log(YesOrNo[i]);
        }
        YesOrNo[0] = 0;
        YesOrNo[1] = 1;
        Invoke("Close", 1);
        voterik[0].SetInteger("Votesik", 1);
        voted[1].SetActive(true);
    }

    public void VoteYesSecond()
    {
        for (int i = 0; i < YesOrNo.Length; i++)
        {
            Debug.Log(YesOrNo[i]);
        }
        YesOrNo[2] = 1;
        YesOrNo[3] = 0;
        voterik[3].SetInteger("Votesik", 1);
        voted[2].SetActive(true);
        Invoke("Cllose2",1);
    }

    public void VoteNoSecond()
    {
        for (int i = 0; i < YesOrNo.Length; i++)
        {
            Debug.Log(YesOrNo[i]);
        }
        YesOrNo[2] = 0;
        YesOrNo[3] = 1;
        Invoke("Close2", 1);
        voterik[2].SetInteger("Votesik", 1);
        voted[3].SetActive(true);
    }

    public void ClosePages() 
    {
        if (SkipQs == 1)
        {
            closes[1].SetInteger("cuse", 1);
        }
        else 
        {
            closes[0].SetInteger("cuse", 1);
        }
        
        Invoke("PodClose",1);
    }

    private void PodClose() 
    {
        Authorization.SetActive(false);
    }

}
