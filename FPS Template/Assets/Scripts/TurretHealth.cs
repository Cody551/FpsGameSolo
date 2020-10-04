using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHealth : MonoBehaviour
{
    private Rigidbody rocket;
    public GameObject spawnpoint;
    

    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        
            gameObject.SetActive(false);
        
       
          
        
        
    }
   
}
