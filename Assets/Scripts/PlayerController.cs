using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent Player;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Player.SetDestination(target.position);
    }
}
