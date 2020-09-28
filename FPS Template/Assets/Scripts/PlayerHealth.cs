using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float startingHealth = 100;                      //total health
    private float currentHealth;                            // current health   
    private bool dead;                                          //if player is dead

    public GameObject rocket;
    public Slider slider;

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



    }

    







    

    // Update is called once per frame
    void Update()
    {
        
        {

        }
    }
}
