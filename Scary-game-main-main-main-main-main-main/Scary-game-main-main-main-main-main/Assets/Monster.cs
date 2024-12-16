using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    public Transform target;
    public float speed;
    NavMeshAgent agent;
    public float viewDistance;

     void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }





    void Update()
    {
        agent.SetDestination(target.position);
        float distance = Vector3.Distance(transform.position, target.position);
        if(distance < viewDistance)
        {
            agent.SetDestination(target.position);
        }


        if (distance < 3)
        {

            float angle = Vector3.Angle(transform.forward, target.transform.forward);
            if (angle < 160f)
            {
                print("boo");



            }

        }   
}   }
