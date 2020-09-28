using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour
{
    public GameObject MoveableBlock;                //the block to be moved
    public GameObject BlockDestination;             //the location to move it too 
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MoveableBlock.transform.position = BlockDestination.transform.position;
        }
        

    }
    
}
