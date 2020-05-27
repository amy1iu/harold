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

    private void OnControllerColliderHit (ControllerColliderHit hit)
	{
		if (hit.gameObject.tag == "oldman")
		{
			this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
			backgroundmusic.gameObject.GetComponent<AudioSource>().Stop();
			gameover.gameObject.GetComponent<AudioSource>().Play();
			Invoke("endGamePlayerController", 10);
			Debug.Log("game has ended");
		}

		if (hit.gameObject.tag == "food")
		{
			foodSFX.gameObject.GetComponent<AudioSource>().Play();
		}
	}
	private void endGamePlayerController()
	{
		instance.endGame();
	}
}
