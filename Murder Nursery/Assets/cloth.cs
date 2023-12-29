using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloth : MonoBehaviour
{
    public float interactionRadius = 2f;
    public LayerMask interactableLayer;
    public GameObject replacementObject; // Drag the replacement GameObject here in the Unity Editor

    void Update()
    {
        CheckForClothInteraction();
    }

    void CheckForClothInteraction()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, interactionRadius, interactableLayer);

        foreach (Collider col in hitColliders)
        {
            if (col.CompareTag("Cloth"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    DestroyCloth(col.gameObject);
                }
            }
        }
    }

    void DestroyCloth(GameObject clothObject)
    {
        Debug.Log("Cloth object destroyed!");

        // Activate the replacement object if available
        if (replacementObject != null)
        {
            replacementObject.SetActive(true);
        }

        Destroy(clothObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactionRadius);
    }
}