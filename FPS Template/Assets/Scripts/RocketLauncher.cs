using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    public bool PlayerControlled = true;                        //Is the RocketLauncher is controlled by the player
    public float fireInterval = 1.0f;                           //How many seconds between shots for the rocket launcher
    private float fireTimer = 0;                                // use this timer to see if we can fire again
    public GameObject rocketPrefab;                             //A reference to the rocket prefab so we can spawn it
    public Vector3 spawnOffset;                                 // a position offset for where the rocket is spawned on the gun so that rockets dont spawn in the gun
    public int ammo = 5;

    public GameObject spawnpoint;                               // refernece to a invisible object to spawn rocket at

    // Start is called before the first frame update
    void Start()
    {
        fireTimer = fireInterval;       //we should start ready to shoot
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;            //Advance our timer

        if(fireTimer >= fireInterval)           //have we waited long enough to fire the gun again        
        {
            //if we are player controlled, has the fire button been pressed?
            if(PlayerControlled && Input.GetButtonDown("Fire1"))
            {
                Fire();
            }
        }
    }
    public void Fire()
    {
        //only fire if we have ammo
        if(ammo <= 0)
        {
            return;
        }
        //spawn a rocketprefab
        GameObject rocketInstance = GameObject.Instantiate<GameObject>(rocketPrefab);

        rocketInstance.transform.position = spawnpoint.transform.position;

        // move our rocket to the desired offset spawn
        //rocketInstance.transform.position = transform.position + transform.right * spawnOffset.x + transform.up * spawnOffset.y + transform.up * spawnOffset.z;

        //rotate the rocket to match the gun rotation 
        rocketInstance.transform.rotation = transform.rotation;

        //reset the shoot timer
        fireTimer = 0.0f;

        //subtract from ammo
        ammo -= 1;
    }


}
