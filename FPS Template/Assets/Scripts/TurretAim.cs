using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TurretAim : MonoBehaviour
{
    
    private GameObject player;
    public Transform turret;
    private bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot == true)
        {
            if (turret != null)
            {
                turret.LookAt(player.transform);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            canShoot = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canShoot = false;
        }
    }


}
