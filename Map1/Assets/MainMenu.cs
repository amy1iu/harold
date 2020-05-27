using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public static bool OptionsEnabled = false;
	//public static bool CreditsEnabled = false;
	public GameObject NotOptionUI;
    public GameObject OptionUI;
    //public GameObject Credits;

	void Start() 
	{
        NotOptionUI.SetActive(true);
        OptionUI.SetActive(false);
        //Credits.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableOptions()
    {
        if(OptionsEnabled == false)
        {
            NotOptionUI.SetActive(false);
            OptionUI.SetActive(true);
            OptionsEnabled = true;
        }
        else
        {
            NotOptionUI.SetActive(true);
            OptionUI.SetActive(false);
            OptionsEnabled = false;
        }
        
    }
    /*public void EnableCredits()
    {
        if(CreditsEnabled == false)
        {
            NotOptionUI.SetActive(false);
            OptionUI.SetActive(true)
            OptionsEnabled = true;
        }
    }*/
}
