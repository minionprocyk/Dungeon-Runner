using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour {

    [SerializeField]
    private Enemy Enemy;

    private Transform targetPlayer;
    private NavMeshAgent navMeshAgent;

    void Start () {
        navMeshAgent = GetComponent<NavMeshAgent>();
        targetPlayer = PlayerManager.instance.player.transform;
	}

    void Update () {
        //float distance = Vector3.Distance(targetPlayer.position, transform.position);

        if(Enemy.InAggroRange(targetPlayer))
        {
            navMeshAgent.SetDestination(targetPlayer.position);
        }
	}

   
}
