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
            SelectWeapon(0);
        }
        else if (Input.GetButtonDown("SelectWeapon2"))
        {
            SelectWeapon(1);
        }
        else if (Input.GetButtonDown("SelectWeapon3"))
        {
            SelectWeapon(2);
        }
    }
    public void CollectWeapon(string collectWeaponName)
    {
        //look at each weapon in our list of selectable weapons
        for (int i = 0; i < weapons.Count; i++)
        {
            //and if we find a match in our list, set its "collected" boolean to true
            if (weapons[i] != null && weapons[i].weaponGameObject.name == collectWeaponName)
            {
                weapons[i].collected = true;
                // also select it
                SelectWeapon(i);
            }
        }
    }

    public void SelectWeapon(int selectedIndex)                     //select the weapon at a specified index of the list
    {
        if (selectedIndex < 0 ||
            selectedIndex >= weapons.Count ||
            weapons[selectedIndex] == null ||
            weapons[selectedIndex].collected == false)
        {
            return;
        }

        //activate the selected weapon and deactive the others
        for (int index = 0; index < weapons.Count; index++)
        {
            if (weapons[index] != null)
            {
                weapons[index].weaponGameObject.SetActive(index == selectedIndex);
            }
        }
    }
}
