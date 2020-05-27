using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider mSlider;
    
    void Start()
    {
        PlayerPrefs.SetFloat("MasterVol", 1f);
        mixer.SetFloat("MasterVol", PlayerPrefs.GetFloat("MasterVol"));
        mSlider.value = PlayerPrefs.GetFloat("MasterVol");

    }
    
    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MasterVol", Mathf.Log10(mSlider.value)*20);
        PlayerPrefs.SetFloat("MasterVol", Mathf.Log10(mSlider.value)*20);
    }
}
