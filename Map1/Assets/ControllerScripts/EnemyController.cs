using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
	GameObject player;
	NavMeshAgent enemy;
	public float HitRadius = 1f;
	Animator animator;

	//startWalk boolean to prevent Librarian from moving before cutscene is over
	private bool startWalk = false;

    // Start is called before the first frame update
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		enemy = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();
		StartCoroutine(FinishCut());
	}

    // Update is called once per frame
	void Update()
	{
		if (startWalk)
		{
			float distance = Vector3.Distance(enemy.transform.position, player.transform.position);
			if (distance <= HitRadius)
			{
				animator.SetBool("IsWalking", false);
			}
			else
			{
				enemy.destination = player.transform.position;
			}
		}
	}

	IEnumerator FinishCut()
	{
		yield return new WaitForSeconds(3);
		startWalk = true;
	}
}
