using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public float startingHealth = 100;                      //total health
    public float currentHealth;                            // current health   
    private bool dead;                                          //if player is dead

    public GameObject rocket;
    public Slider slider;
   
    public GameObject mainRespawnpoint;

    private void OnEnable()
    {
        
    }

    void Start()
    {
        currentHealth = startingHealth;
        
        SetHealthUI();
    }


    private void SetHealthUI()
    {
        slider.value = currentHealth;
    }


    public void TakeDamage(float amount)
    {
        currentHealth -= amount;                        //reduce health by damage done

        SetHealthUI();

        if (currentHealth <= 0f )
        {
            OnDeath();
            
        }

    }

    public void OnDeath()
    {

        



      

       

        gameObject.transform.position = mainRespawnpoint.transform.position;
       gameObject.transform.rotation = mainRespawnpoint.transform.rotation;
        Physics.SyncTransforms();

    }


   




    

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
