using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scissors: MonoBehaviour
{
    public float interactionRadius = 2f;
    public LayerMask interactableLayer;
    public Canvas interactionCanvas; // Reference to the Canvas assigned in Unity Editor
    public GameObject interactionPromptPrefab; // Prefab with a TextMeshProUGUI component
    private GameObject interactionPrompt;

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
            if (col.CompareTag("Item") || col.CompareTag("Breakable"))
            {
                showPrompt = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (col.CompareTag("Item"))
                    {
                        CollectItem(col.gameObject);
                    }
                    else if (col.CompareTag("Breakable"))
                    {
                        DestroyBreakable(col.gameObject);
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

    void CollectItem(GameObject item)
    {
        Debug.Log("Item collected!");
        Destroy(item);
        HideInteractionPrompt();
    }

    void DestroyBreakable(GameObject breakable)
    {
        Debug.Log("Breakable destroyed!");
        Destroy(breakable);
        HideInteractionPrompt();
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