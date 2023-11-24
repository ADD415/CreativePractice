using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bribing : MonoBehaviour // Script is added to SingleBribe UI OBject
{
    public GameObject manager; //Stores the game manager
    private GameObject activeNPC; //Stores the active NPC
    //private Item firstBribe = null; //First bribe slot
    //private Item secondBribe = null; //Second bribe slot

    private List<Item> briberyItems = new(); // used in StoreInfo() bribery items are added to it so we know which items to remove during a successful bribe

    public GameObject bribePanel; //UI element which stores the bribe panel
    public GameObject inventoryManager; //Stores the inventory manager for easy access to held items

    public void Start()
    {
        //firstBribe = null; //Ensures that the bribes are reset at the start of play
        //secondBribe = null;
    }


    private void Update()
    {
        activeNPC = manager.GetComponent<DialogueManager>().activeNPC; //Stores the active NPC
    }
    public void AttemptBribeButton() //Called when the player attempts to bribe an NPC using the first bribe slot 
    {
        if(manager.GetComponent<DialogueManager>().activeNPC.GetComponent<NPCDialogue>().bribeGiven)
        {
            manager.GetComponent<DialogueManager>().LoadBribeDialogue(activeNPC.GetComponent<NPCDialogue>().bribePath);
            bribePanel.SetActive(false); //Deactivates the bribe panel
        }
        if(gameObject.name == activeNPC.GetComponent<NPCDialogue>().bribeItem && !manager.GetComponent<DialogueManager>().activeNPC.GetComponent<NPCDialogue>().bribeGiven)
        {
            manager.GetComponent<DialogueManager>().activeNode.bribeGiven = true; //Signals that the bribe has been accepted
            manager.GetComponent<DialogueManager>().LoadBribeDialogue(activeNPC.GetComponent<NPCDialogue>().bribePath);
            manager.GetComponent<DialogueManager>().activeNPC.GetComponent<NPCDialogue>().bribeGiven = true;
            bribePanel.SetActive(false); //Deactivates the bribe panel

            // remove item from bribery items panel
            for (int i = 0; i < briberyItems.Count; i++)
            {
                if(briberyItems[i].name == gameObject.name)
                {
                    inventoryManager.GetComponent<InventoryManager>().RemoveItem(briberyItems[i]); //Removes the item from the player's inventory
                    Destroy(gameObject);
                }
            }
        }
        else 
        {
            manager.GetComponent<DialogueManager>().LoadBribeDialogue(activeNPC.GetComponent<NPCDialogue>().bribeFailPath); //Triggers a bribery fail scenario
            bribePanel.SetActive(false); //Deactivates the bribe panel
        }
    }

    //public void AttemptBribeButton2() //Same as previous method but with different slot
    //{
    //    if(secondBribe.itemName == activeNPC.GetComponent<NPCDialogue>().bribeItem)
    //    {
    //        manager.GetComponent<DialogueManager>().activeNode.bribeGiven = true;
    //        manager.GetComponent<DialogueManager>().StartConversation(activeNPC.GetComponent<NPCDialogue>().bribePath, activeNPC, activeNPC.GetComponent<NPCDialogue>().npcCam);
    //        bribePanel.SetActive(false);
    //        for (int i = 0; i < inventoryManager.GetComponent<InventoryManager>().items.Count; i++)
    //        {
    //            if(inventoryManager.GetComponent<InventoryManager>().items[i] == secondBribe)
    //            {
    //                inventoryManager.GetComponent<InventoryManager>().RemoveItem(inventoryManager.GetComponent<InventoryManager>().items[i]);
    //                //Destroy(inventoryManager.GetComponent<InventoryManager>().invItems[i]);
    //            }
    //        }

    //    }
    //    else manager.GetComponent<DialogueManager>().StartConversation(activeNPC.GetComponent<NPCDialogue>().bribeFailPath, activeNPC, activeNPC.GetComponent<NPCDialogue>().npcCam);
    //    bribePanel.SetActive(false);
    
    //}

    public void StoreInfo(Item item) //Stores the potential bribes when relevant items are collected
    {
        //if (firstBribe != null && secondBribe == null)
        //{
        //    secondBribe = item;
        //}
        //if (firstBribe == null)
        //{
        //    firstBribe = item;
        //}

        briberyItems.Add(item);
        
    }
}
