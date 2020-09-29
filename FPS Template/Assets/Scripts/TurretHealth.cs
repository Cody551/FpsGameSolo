using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHealth : MonoBehaviour
{

    public GameObject spawnpoint;
    private void OnCollisionEnter(Collision collision)
    {

        spawnpoint.gameObject.SetActive(false);
          
        
        
    }

}
