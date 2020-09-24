using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour
{
    public GameObject MoveableBlock;                //the block to be moved
    public GameObject BlockDestination;             //the location to move it too 
    


    private void OnTriggerEnter(Collider other)
    {
        
        MoveableBlock.transform.position = BlockDestination.transform.position;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
