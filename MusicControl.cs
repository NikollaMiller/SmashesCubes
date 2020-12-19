using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicControl : MonoBehaviour
{
    ////////////MUSIC CONTROLL//////////////
    public Slider MusicSlider;
    public AudioSource Music;
    ////////////MUSIC CONTROLL//////////////

    ////////////Sound CONTROLL//////////////
    public Slider SoundSlider;
    public AudioSource Sound;
    ////////////Sound CONTROLL//////////////


    public void Start()
    {
        MusicSlider.value = PlayerPrefs.GetFloat("Music", MusicSlider.value);

        SoundSlider.value = PlayerPrefs.GetFloat("Sound", SoundSlider.value);
    }

    public void Update()
    {
        Music.volume = MusicSlider.value;

        Sound.volume = SoundSlider.value;

        PlayerPrefs.SetFloat("Music", MusicSlider.value);

        PlayerPrefs.SetFloat("Sound", SoundSlider.value);
    }

    public void OffMusicAndSound() 
    {
        Music.enabled = !Music.enabled;
        Sound.enabled = !Sound.enabled;
    }

    public void OffMusic() 
    {
        Music.enabled = !Music.enabled;
    }

    public void OffSound()
    {
        Sound.enabled = !Sound.enabled;
    }
}
