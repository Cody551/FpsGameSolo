using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDamage : MonoBehaviour
{
    public float lifeTime = 2f;                                     //time before the shell is deleted from the game
    public float Damage = 20f;





    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody targetRigidbody = collision.gameObject.GetComponent<Rigidbody>();
        if(targetRigidbody != null)
        {
            PlayerHealth targethealth = targetRigidbody.GetComponent<PlayerHealth>();
            if (targethealth != null)
            {
                targethealth.TakeDamage(Damage);


            }
        }
       

        Destroy(gameObject);
            
       
    }






    // Update is called once per frame
    void Update()
    {
        
    }

    
}
