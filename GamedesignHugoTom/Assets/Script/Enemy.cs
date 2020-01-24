using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject _target = null;
    private NavMeshAgent _navMeshAgent = null;
    [SerializeField] public float _health = 15f;
    [SerializeField] public float _speed = 6f;
    [SerializeField] public float _damage = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _navMeshAgent.SetDestination(_target.transform.position);
    }
}
