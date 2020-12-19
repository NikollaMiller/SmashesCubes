using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationAfterClick : MonoBehaviour
{
    public Animator PlayBTN;
    public Animator replayBar;
    public Animator StarCountAn;
    public GameObject replayBarik;
    public GameObject starcounter;
    public GameObject Menu;
    public bool da;

    public void Update() 
    {
        if (da)
        {
            StarCountAn.SetInteger("Clics",1);
            PlayBTN.SetInteger("clicked", 1);
        }
    }

    public void PlayAnim() 
    {
        da = true;
        Invoke("OffAnimeMenuAfterClick",1f);
    }

    public void OffAnimeMenuAfterClick() 
    {
        starcounter.SetActive(false);
        Menu.SetActive(false);
        da = false;
    }

    public void ExitAnim() 
    {
        da = true;
        Invoke("BetweenTime",1.4f);
    }

    private void BetweenTime() 
    {
        Application.Quit();
    }

    public void CloseReplay() 
    {
        replayBar.SetInteger("replikant",1);
        Invoke("Delreplay",1);
    }

    private void Delreplay() 
    {
        replayBarik.SetActive(false);
    }
}
