﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text Timer;
    public Text Score;
    public GameObject Food;
    public GameObject deathMenu;
    public AudioSource backgroundmusic;
    public AudioSource foodSFX;
    public AudioSource gameover;
    public GameObject enemy;
    public TextMeshProUGUI endGameText;

    public static int highScore;

    private float secondsTotal = 120;
    private float secondsElapsed = 0;
    private float lastTime = 0;
    private string minutes;
    private string seconds;
    private bool outOfTime = false;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        setTimer();
        setScoreText();
        deathMenu.SetActive(false);
        Time.timeScale = 1f;
        secondsTotal = 15 + 5 * (Mathf.Round(10 * (1 - PlayerPrefs.GetFloat("Difficulty"))));//gets a value 1-10, 10 is easiest. each point is an additional 5 seconds

        highScore = PlayerPrefs.GetInt("highScore", highScore);
    }

    void setTimer()
    {
        /*
        if (seconds == 0)
        {
            Timer.text = minutes.ToString() + ":00";
        }
        else if (seconds < 10)
        {
            Timer.text = minutes.ToString() + ":0" + seconds.ToString();
        }
        else
        {
            Timer.text = minutes.ToString() + ":" + seconds.ToString();
        }*/

        Timer.text = (minutes) + ":" + (seconds);//Timer.text = minutes.ToString() + ":00";
    }

    void setScoreText()
    {
        Score.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        secondsElapsed = (Mathf.Round(Time.timeSinceLevelLoad - lastTime));
        minutes = ((int)((secondsTotal - secondsElapsed) / 60)).ToString();
        if (outOfTime == false)
        {
            if ((int)((secondsTotal - secondsElapsed) % 60) == 0)
            {
                seconds = "00";
            }
            else if ((int)((secondsTotal - secondsElapsed) % 60) < 10)
            {
                seconds = "0" + ((secondsTotal - secondsElapsed) % 60).ToString();
            }
            else
            {
                seconds = ((int)(secondsTotal - secondsElapsed) % 60).ToString();
            }
        }
        if (secondsElapsed == secondsTotal)
        {
            outOfTime = true;
            Timer.color = Color.red;
            seconds = "00";
            minutes = "00";
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            this.gameObject.GetComponent<CharacterController>().enabled = false;
            backgroundmusic.gameObject.GetComponent<AudioSource>().Stop();
            gameover.gameObject.GetComponent<AudioSource>().Play();
            Invoke("endGame", 10);
        }
        setTimer();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.name == "Food Sphere")
        {
            score++;
            if (score > highScore)
            {
                highScore = score;
                print(highScore);
                PlayerPrefs.SetInt("highScore", highScore);
            }
            setScoreText();
            //Destroy(hit.gameObject);
            lastTime = Time.timeSinceLevelLoad;

            Food.SendMessage("teleport");
        }
    }


    public void endGame()
    {
        endGameText.text = "You were caught eating in the library \n Score: " + score + "\n Highscore: " + highScore;
        deathMenu.SetActive(true);
        Time.timeScale = 0f;
        this.gameObject.GetComponent<CharacterController>().enabled = true;
    }

}
