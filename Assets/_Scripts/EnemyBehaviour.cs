using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent nma;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        nma = GetComponent<UnityEngine.AI.NavMeshAgent>();    
    }

    // Update is called once per frame
    void Update()
    {
        nma.SetDestination(player.position);
    }
}
