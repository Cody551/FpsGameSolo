using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public bool WinningTrigger = false;

    [SerializeField]
    private GameObject player;
    public GameObject mainRespawnPoint;
    
     
    
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            WinningTrigger = true;
               
            player.gameObject.transform.position = mainRespawnPoint.transform.position;
            Physics.SyncTransforms();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        WinningTrigger = false;
    }
}
