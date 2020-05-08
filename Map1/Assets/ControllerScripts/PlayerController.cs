using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text Timer;
    public Text Score;
    public GameObject Food;
    public AudioSource backgroundmusic;
    public AudioSource foodSFX;
    public AudioSource gameover;

    private int minutes = 2;
    private int seconds = 0;
    private int counter = 0;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        setTimer();
        setScoreText();
    }

    void setTimer()
    {
        if (seconds == 0)
        {
            Timer.text = minutes.ToString() + ":00";
        }
        else
        {
            Timer.text = minutes.ToString() + ":" + seconds.ToString();
        }
    }

    void setScoreText()
    {
        Score.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == 60)
        {
            counter = 0;
            if (seconds == 0)
            {
                if (minutes == 0)
                {
                    seconds = 0;
                    Timer.color = Color.red;
                    this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                    backgroundmusic.gameObject.GetComponent<AudioSource>().Stop();
                    gameover.gameObject.GetComponent<AudioSource>().Play();
                }
                else
                {
                    seconds = 59;
                    minutes--;
                }
            }
            else
            {
                seconds--;
            }
        }
        setTimer();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "Sphere")
        {
            score++;
            setScoreText();
            //Destroy(hit.gameObject);
            minutes = 2;
            seconds = 0;
            counter = 0;

            Food.SendMessage("teleport");
        }
    }

}
