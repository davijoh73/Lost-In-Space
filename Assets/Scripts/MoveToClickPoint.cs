using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToClickPoint : MonoBehaviour
{

    NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                if (hit.collider.CompareTag("Item") || hit.collider.CompareTag("Wall"))
                {
                    agent.isStopped = true;
                }
                else
                {
                    agent.destination = hit.point;
                    agent.isStopped = false;
                }
            }
        }
    }
}
