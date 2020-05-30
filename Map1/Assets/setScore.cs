using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;
using TMPro;

public class setScore : MonoBehaviour
{
    public TextMeshProUGUI gameOverMessage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void set(int score, int highscore)
    {
        gameOverMessage.text = "You were caught eating in the library \n Score: " + score + "\n Highscore: " + highscore;
    }
}
