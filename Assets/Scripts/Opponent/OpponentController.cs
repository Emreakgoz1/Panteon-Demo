using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OpponentController : MonoBehaviour
{
    [SerializeField] private Transform MovePositionTransform;
    private NavMeshAgent navMeshAgent;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        navMeshAgent.destination = MovePositionTransform.position;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Engel")
        {
            Debug.Log("Çarptýn");
        }
    }
}
