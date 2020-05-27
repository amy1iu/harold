using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SetDiff : MonoBehaviour
{
    public Slider nSlider;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Difficulty", 0.5f);
        nSlider.value = PlayerPrefs.GetFloat("Difficulty");
    }

    public void SetDiffLevel(float sliderValue)
    {
        PlayerPrefs.SetFloat("Difficulty", nSlider.value);
    }
}
