using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    public float fireTimer = 0;
    public float fireInterval = 1;
    public GameObject rocketPreFab;
    public GameObject spawnpoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;            //Advance our timer

        if (fireTimer >= fireInterval)           //have we waited long enough to fire  again        
        {
            Fire();
        }
    }



    public void Fire()
    {
        GameObject rocketInstance = GameObject.Instantiate<GameObject>(rocketPreFab);

        rocketInstance.transform.position = spawnpoint.transform.position;
        rocketInstance.transform.rotation = spawnpoint.transform.rotation;

        fireTimer = 0;
    }
}
