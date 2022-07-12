using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour

{
    NavMeshAgent agent;
    public GameObject cube;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
       if (Input.GetMouseButton.Down(0))
       {
            Ray ray;
            RaycastHit hit;
            ray = Camera.main.SetPointToRay(Input.MousePosition);
            if (Physics.Raycast(Ray, out hit))
            {
                agent.SetDestination(cube.transform.position);
            }
       }
        
        
    }
}