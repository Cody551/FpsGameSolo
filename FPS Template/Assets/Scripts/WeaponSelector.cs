using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector : MonoBehaviour
{
    // define a custom class that were using to associate a reference to a weapon along with whether or not we have collected it
    [System.Serializable]
    public class SelectableWeapon
    {
        public GameObject weaponGameObject;
        public bool collected = false;


    }

    public List<SelectableWeapon> weapons = new List<SelectableWeapon>();      //this is a list of the selectable weapons class, this is where our data is stored

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //here we have one button per weapon, and select the weapon if the associated button is pressed. alternatively, we could implement prev/next weapon buttons
        if (Input.GetButtonDown("SelectWeapon1"))
        {
            //select weapon(0);
        }
        else if (Input.GetButtonDown("SelectWeapon2"))
        {

        }
        else if (Input.GetButtonDown("SelectWeapon3"))
        {

        }
    }
    public void CollectWeapon(string collectWeaponName)
    {

    }
}
