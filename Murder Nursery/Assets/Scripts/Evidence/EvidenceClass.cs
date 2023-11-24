using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EvidenceClass : MonoBehaviour
{
    public string evidenceText; //The text relevant to the evidenc piece
    public bool evidenceFound = false; //Signals whether or not the evidence has been found
    public int evidenceID; //The evidence ID number
    public GameObject pinBoardManager; //Stores the pinboard manager
    public GameObject evidenceList; //Stores the evidence list 
    public GameObject evidenceImage; //Stores the evidence image
   
    // Start is called before the first frame update
    public void Start()
    {
        evidenceFound = false; //Marks the evidence as undiscovered
    }
}
