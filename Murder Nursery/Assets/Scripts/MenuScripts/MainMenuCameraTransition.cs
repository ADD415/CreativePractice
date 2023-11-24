using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainMenuCameraTransition : MonoBehaviour
{
    // stores the location for the camera to transition too
    public GameObject defaultPosition, controlsPosition;

    // used for showing/hiding UI elements
    public GameObject menuUI, controlsUI;

    // List of all posible positions camera can transition to
    private List<GameObject> positions = new List<GameObject>();

    // allows for toggling between UI being visible/hidden
    bool menuOpen = true;
    bool controlsOpen;

    private void Awake()
    {
        positions.Add(defaultPosition); // cameras start location
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPosition(); // Called each frame as the cameras transform uses deltaTime when transitioning position
    }

    void MoveToPosition()
    {
        if(positions.Count > 0)
        {
            // transform relates to the cameras transform as the script is attached to the camera
            // Lerp used to provide a smooth transition between positions (x * Time.deltaTime to control the speed of the Lerp)
            transform.SetPositionAndRotation(Vector3.Lerp(transform.position,
                positions[0].transform.position, 1.5f * Time.deltaTime), Quaternion.Lerp(transform.rotation,
                positions[0].transform.rotation, 1.5f * Time.deltaTime));
        }
    }

    // Called as an OnClick() Event when clicking Controls or Return Icon UI
    // If index not set to 0, camera position will transition to controls position
    public void ChangePosition(int index)
    {
        positions.RemoveAt(0); // removes current position element before adding the position to change to

        if(index == 0)
        {
            positions.Add(defaultPosition);
        }
        else
        {
            positions.Add(controlsPosition);
        }
    }

    // Sets which UI Elements are visible/hidden
    // Called as an OnClick() Event when clicking Controls or Return Icon UI
    public void ToggleMenus()
    {
        if(menuOpen = !menuOpen)
        {
            menuUI.SetActive(true);
            menuOpen = true;
        }
        else
        {
            menuUI.SetActive(false);
            menuOpen = false;
        }

        if(controlsOpen = !controlsOpen)
        {
            controlsUI.SetActive(true);
            controlsOpen = true;
        }
        else
        {
            controlsUI.SetActive(false);
            controlsOpen = false;
        }
    }
}
