using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUse : MonoBehaviour
{
    public float interactionRadius = 2f;
    public LayerMask interactableLayer;
    public Canvas interactionCanvas; // Reference to the Canvas assigned in Unity Editor
    public GameObject interactionPromptPrefab; // Prefab with a TextMeshProUGUI component
    private GameObject interactionPrompt;

    private bool hasKey = false;
    private GameObject currentInteractable;

    void Start()
    {
        if (interactionPromptPrefab != null)
        {
            interactionPrompt = Instantiate(interactionPromptPrefab);
            interactionPrompt.SetActive(false);

            if (interactionCanvas != null)
            {
                interactionPrompt.transform.SetParent(interactionCanvas.transform, false);
            }
            else
            {
                Debug.LogError("Interaction Canvas is not assigned in the Unity Editor!");
            }
        }
        else
        {
            Debug.LogError("Interaction prompt prefab is not assigned.");
        }
    }

    void Update()
    {
        CheckForInteraction();
    }

    void CheckForInteraction()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, interactionRadius, interactableLayer);

        bool showPrompt = false;

        foreach (Collider col in hitColliders)
        {
            if (col.CompareTag("Key") || col.CompareTag("Door"))
            {
                showPrompt = true;
                currentInteractable = col.gameObject;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (col.CompareTag("Key"))
                    {
                        CollectKey();
                    }
                    else if (col.CompareTag("Door"))
                    {
                        OpenDoor();
                    }
                }
            }
        }

        if (showPrompt)
        {
            ShowInteractionPrompt();
        }
        else
        {
            HideInteractionPrompt();
        }
    }

    void CollectKey()
    {
        Debug.Log("Key collected!");
        Destroy(currentInteractable);
        hasKey = true;
        HideInteractionPrompt();
    }

    void OpenDoor()
    {
        if (hasKey)
        {
            Debug.Log("Door opened!");
            // Handle opening the door in the DoorController script
            // For demonstration purposes, let's assume the door rotation is handled by DoorController script
            currentInteractable.GetComponent<DoorController>().RotateDoor();
            HideInteractionPrompt();
        }
        else
        {
            Debug.Log("You need a key to open this door!");
        }
    }

    void ShowInteractionPrompt()
    {
        if (interactionPrompt != null)
        {
            interactionPrompt.SetActive(true);
        }
    }

    void HideInteractionPrompt()
    {
        if (interactionPrompt != null)
        {
            interactionPrompt.SetActive(false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactionRadius);
    }
}
