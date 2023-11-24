using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EvidenceItem : MonoBehaviour
{
    public static EvidenceItem evidenceItem;
    public Item item; // item to add to inventory to check who owns the item (fingerprint)
    public GameObject evidenceToAdd; // evidence to add to pinboard
    public GameObject inspectPos;
    public float rotationSpeed;
    public GameObject helpText;

    [HideInInspector]
    public bool inspectingItem;

    bool lerpStopped;
    float screenWidth;
    float screenHeight;
    Vector3 pressPoint;
    Quaternion startRotation;

    private void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
    }

    public void InspectItem()
    {
        lerpStopped = false;
        StartCoroutine(LerpPosition(inspectPos.transform.position, 1));
        inspectingItem = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        
    }

    // lerp object towards camera for a zoom in effect when inspecting the item
    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration)
        {
            transform.SetPositionAndRotation(Vector3.Lerp(startPosition, targetPosition, time / duration), transform.rotation);
            time += Time.deltaTime;
            yield return null;
        }

        if(time >= duration)
        {
            lerpStopped = true;
            helpText.SetActive(true);
        }
            
    }

    private void Update()
    {
        if(lerpStopped)
        {
            if (Input.GetMouseButtonDown(0))
            {
                pressPoint = Input.mousePosition;
                startRotation = transform.rotation;
            }
            else if (Input.GetMouseButton(0))
            {
                // rotate object upwards/downwards
                float MouseYPos = (Input.mousePosition - pressPoint).y;

                // rotate object left/right
                float MouseXPos = (Input.mousePosition - pressPoint).x;

                // rotate object relative to mouse position
                transform.rotation = startRotation * Quaternion.Euler((MouseYPos / screenWidth) * 360 * rotationSpeed, -(MouseXPos / screenHeight) * 360 * rotationSpeed, 0f);
            }

        }

        if(inspectingItem == true && Cursor.visible == false)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;            
        }

        if(gameObject.GetComponent<MeshRenderer>().enabled == true && gameObject.activeInHierarchy)
        {
            evidenceItem = this;
        }
    }
}
