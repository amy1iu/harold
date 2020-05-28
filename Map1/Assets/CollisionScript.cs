using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    
	public AudioSource backgroundmusic;
	public AudioSource foodSFX;
	public AudioSource gameover;
	public PlayerController instance;

	void Start()
    {
        backgroundmusic.gameObject.GetComponent<AudioSource>().Play();
    }

    private void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "food")
        {
            foodSFX.gameObject.GetComponent<AudioSource>().Play();
        }
        
        if (hit.gameObject.tag == "oldman")
        {
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            this.gameObject.GetComponent<CharacterController>().enabled = false;
            
            backgroundmusic.gameObject.GetComponent<AudioSource>().Stop();
            gameover.gameObject.GetComponent<AudioSource>().Play();

            Invoke("endGamePlayerController", 10);
			Debug.Log("game has ended");
        }
    }

	private void endGamePlayerController()
	{
		instance.endGame();
        this.gameObject.GetComponent<CharacterController>().enabled = true;
	}
}
