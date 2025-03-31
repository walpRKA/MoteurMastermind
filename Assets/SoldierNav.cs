using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SoldierNav : MonoBehaviour
{
    [SerializeField] private GameObject _target;
  
    Animator animator;

    private NavMeshAgent _agent;

    private void Start()
    {
        animator = GetComponent<Animator>();
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(_target.transform.position);

    }
    private void Update()
    {

        animator.SetFloat("runParameter", _agent.velocity.magnitude);
        
    }
}
