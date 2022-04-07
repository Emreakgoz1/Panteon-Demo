using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshCharacterController : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Finish");
    }

    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
