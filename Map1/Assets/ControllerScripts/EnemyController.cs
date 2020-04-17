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

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
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
