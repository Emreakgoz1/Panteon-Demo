using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OpponentController : MonoBehaviour
{
   // [SerializeField] Transform MovePositionTransform;
    private NavMeshAgent navMeshAgent;
    public GameObject target;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        this.gameObject.GetComponent<NavMeshAgent>().destination = target.transform.position;
    }
    
}
