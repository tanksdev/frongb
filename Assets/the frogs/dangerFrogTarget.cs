using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerFrogTarget : MonoBehaviour
{
    // Start is called before the first frame update
      public Transform safeFrogpos;
      //refers to the safe frogs' position, transform because of its shifting
    UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
       agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
       //references the object's navmesh agent component
    }
    void Update()
    {
        
          agent.destination = safeFrogpos.position;
          //folows the position of safe frogs
        
    }
}