using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour {

    public float lookRadius;

    private Transform targetPlayer;
    private NavMeshAgent navMeshAgent;

    void Start () {
        navMeshAgent = GetComponent<NavMeshAgent>();
        targetPlayer = PlayerManager.instance.player.transform;
	}

    void Update () {
        float distance = Vector3.Distance(targetPlayer.position, transform.position);

        if(distance <= lookRadius)
        {
            navMeshAgent.SetDestination(targetPlayer.position);
        }
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
