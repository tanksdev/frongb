using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class dangerFrogTarget : MonoBehaviour
{
  private GameObject dangerousFrog;
  private GameObject safeFrog;
  //private Transform safeFrogpos;
  private GameObject safeFrogpos;
  private NavMeshAgent agent;
      //refers to the safe frogs' position, Transform because of its moving
    //UnityEngine.AI.NavMeshAgent agent;
    void Start()
    {
       agent = GetComponent<NavMeshAgent>();
       //references the object's navmesh agent component
       safeFrogpos = GameObject.FindGameObjectWithTag ("Frog");
    }
    void Update()
    {
      { 
        if (Time.frameCount % 30 == 0);
      }
          agent.SetDestination (safeFrogpos.transform.position);
          //folows the position of safe frogs
    }
}