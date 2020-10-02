using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public bool WinningTrigger = false;

    [SerializeField]
    private GameObject player;
    
     
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("box is triggered");
        if (other.CompareTag("Player"))
        {
            WinningTrigger = true;
                Debug.Log("yummy");
            
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        WinningTrigger = false;
    }
}
