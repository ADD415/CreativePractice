using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MagnifyingGlass : MonoBehaviour
{
    PinboardManager PM;

    [HideInInspector]
    public bool usingMagnifyingGlass; // used in player movement script for switching from third/first person movement

    [HideInInspector]
    public GameObject evidenceItem; // item the player is currently viewing through the magnifying glass

    
    public GameObject thirdPersonCam;

    
    public GameObject firstPersonCam; // first person camera

    public GameObject magnifyingBlur; // activates a blur effect whilst using the MG

    [SerializeField]
    GameObject magGlass; // hide mag glass when inspecting item

    [SerializeField]
    GameObject storeItemText; // text pop up to inform player they can pick up the evidence

    [SerializeField]
    GameObject fingerprintUI; // check that it is not currently active before toggling mag glass

    [SerializeField]
    GameObject dresserBox; // check which outfit is active

    

    private void Start()
    {
        PM = FindObjectOfType<PinboardManager>();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.E) && evidenceItem && evidenceItem.activeInHierarchy)
        {
            GameObject evidenceUI = evidenceItem.GetComponent<EvidenceItem>().evidenceToAdd; // evidence to add to pinboard
            storeItemText.SetActive(false);

            if(!evidenceUI.GetComponent<EvidenceClass>().evidenceFound) // check the evidence hasnt already been found
            {
                // update the pinboard with new evidence
                PM.discoveredEvidence.Add(evidenceUI.GetComponent<EvidenceClass>());
                PM.UpdateEvidenceImages(evidenceUI.GetComponent<EvidenceClass>());
                evidenceUI.GetComponent<EvidenceClass>().evidenceFound = true;
            }

            // check if item has a fingerprint for inspection
            if(evidenceItem.GetComponentInChildren<Fingerprint>())
            {
                evidenceItem.GetComponent<EvidenceItem>().InspectItem();
                magnifyingBlur.SetActive(false);
                evidenceItem.GetComponent<ParticleSystem>().Stop();
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(evidenceItem);
            }

        }
    }

    // transitions between third person / first person camera &
    // toggles a magnifying glass to be used for finding evidence
    public void ToggleMagnifyingGlass() 
    {

        if(evidenceItem)
        {
            if(!evidenceItem.GetComponent<EvidenceItem>().inspectingItem)
            {
                if(usingMagnifyingGlass = !usingMagnifyingGlass && !fingerprintUI.activeInHierarchy)
                {
                    usingMagnifyingGlass = true;
                    thirdPersonCam.SetActive(false);
                    firstPersonCam.SetActive(true);
                    gameObject.SetActive(true);
                    magnifyingBlur.SetActive(true);   
                }
                else
                {
                    usingMagnifyingGlass = false;
                    firstPersonCam.SetActive(false);
                    thirdPersonCam.SetActive(true);
                    magnifyingBlur.SetActive(false);
                    storeItemText.SetActive(false);
                }
            }
        }
        else
        {
            if(!usingMagnifyingGlass && !fingerprintUI.activeInHierarchy)
            {
                usingMagnifyingGlass = true;
                thirdPersonCam.SetActive(false);
                firstPersonCam.SetActive(true);
                gameObject.SetActive(true);
                magnifyingBlur.SetActive(true);   
            }
            else
            {
                usingMagnifyingGlass = false;
                firstPersonCam.SetActive(false);
                thirdPersonCam.SetActive(true);
                magnifyingBlur.SetActive(false);
                storeItemText.SetActive(false);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Evidence Item") && usingMagnifyingGlass)
        {
            if (other.gameObject.GetComponentInChildren<Fingerprint>())
            {
                GameObject fingerprint = other.gameObject.GetComponentInChildren<Fingerprint>().gameObject;
                fingerprint.GetComponent<SpriteRenderer>().enabled = true;
            }

            other.gameObject.GetComponent<MeshRenderer>().enabled = true; // allows player to see the item
            other.gameObject.GetComponent<ParticleSystem>().Play(); // plays the particle effect attached to item
            evidenceItem = other.gameObject;

            if(evidenceItem.GetComponentInChildren<Fingerprint>())
            {
                storeItemText.GetComponent<TextMeshProUGUI>().text = "Press [E] to inspect " + other.name;
            }
            else
            {
                storeItemText.GetComponent<TextMeshProUGUI>().text = "Press [E] to store evidence " + other.name;
            }
            storeItemText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Evidence Item") && usingMagnifyingGlass)
        {
            other.gameObject.GetComponent<ParticleSystem>().Stop();

            storeItemText.SetActive(false);

            evidenceItem = null;
        }
    }

    public bool OutfitCheck()
    {
        if (dresserBox.GetComponent<DressUp>().activeOutfit == "Detective Outfit")
        {
            return true;
        }
        else return false;
    }
}
