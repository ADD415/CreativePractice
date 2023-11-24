using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingActivation : MonoBehaviour
{
    public GameObject filter; //The post processing layer
    private bool filterOn; //Signals whether or not the PP layer is active

    // Start is called before the first frame update
    void Start()
    {
        filterOn = false; //Turns the filter off 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnFilterOn(bool filterStatus) //Used to activate and deactivate the filter
    {
        filterOn = filterStatus;
        filter.GetComponent<PostProcessLayer>().enabled = filterOn;
    }
}