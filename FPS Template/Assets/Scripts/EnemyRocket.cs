using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRocket : MonoBehaviour
{
    Rigidbody rocketRB;
   public float rocketSpeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        rocketRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(rocketRB != null)
        {
            rocketRB.AddForce(gameObject.transform.forward * rocketSpeed, ForceMode.Force);
        }
        
    }
}
