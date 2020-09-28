using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    //the name of the weapon this should be enabled upon collection 
    public string weaponname = string.Empty;

    private void OnTriggerEnter(Collider other)
    {
        //does the gameobject that collided with this weapon have a weaponselector component
        WeaponSelector weaponSelector = other.gameObject.GetComponentInChildren<WeaponSelector>();
        //if there is a weaponselector, tell it to mark the matching weapon as collected 
        if(weaponSelector != null)
        {
            weaponSelector.CollectWeapon(weaponname);
            gameObject.SetActive(false);
        }
    }
}
