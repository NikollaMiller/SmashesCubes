using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedSound : MonoBehaviour
{
    public AudioSource clickSound;

    public void SoundPerClick()
    {
        clickSound.Play();
    }
}
