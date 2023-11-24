using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToggle : MonoBehaviour
{
    private bool menuOpen = false; //Signals if the help menu is open
    public GameObject menu; //The UI object being opened 


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle() //Is used to open and close the menu 
    {
        menuOpen = !menuOpen;
        menu.SetActive(menuOpen);

    }
}
