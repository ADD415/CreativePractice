using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour, IDropHandler
{
    [SerializeField]
    Transform content;


    [SerializeField]
    int slotID = 0;


    bool itemInSlot;
    public GameObject pinboardManager;
    public GameObject chaseZone;
    public int chaseCount = 0;
    public int chasePlacedCount = 0;
    public int scarletCount = 0;
    public int scarletPlacedCount = 0;
    public int eddieCount = 0;
    public int eddiePlacedCount = 0;
    public int juiceBoxCount = 0;
    public int juiceBoxPlacedCount = 0;
    public int graceCount = 0;
    public int gracePlacedCount = 0;

    public List<GameObject> placedScarletPieces = new List<GameObject>();
    public List<GameObject> placedJuiceBoxPieces = new List<GameObject>();
    public List<GameObject> placedGracePieces = new List<GameObject>();
    public List<GameObject> placedChasePieces = new List<GameObject>();
    public List<GameObject> placedEddiePieces = new List<GameObject>();
    public void Start()
    {
        chaseCount = 0;
        scarletCount = 0;
    }
    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag.GetComponent<DragAndDrop>() != null)
        {
            if (eventData.pointerDrag.GetComponent<DragAndDrop>().itemID == slotID)
            {
                Debug.Log("Correct Slot");
                switch (slotID) //SWITCH STATEMENT REUIRED MAJOR REWORKING FOR EFFICIENCY
                {
                    case 0:

                        //print("Chase Evidence Placed");
                       // for (chaseCount = 0; chaseCount < 8; chaseCount++)
                        //{
                       //     if (pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().slotFilled)
                      //      {
                      //          return;
                      //      }
                           // if (!pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().slotFilled)
                           // {
                            //    pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                            //    pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().slotFilled = true;
                            //    pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                            //    pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                            //    placedChasePieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                            //    pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().prefab = placedChasePieces[chasePlacedCount];
                            //    chasePlacedCount++;
                            //    break;
                          //  }
                      //  }
                       // break;
                    case 1:
                        print("Scarlet Evidence Placed");
                        for (scarletCount = 0; scarletCount < 8; scarletCount++)
                        {
                         //   if (pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().slotFilled)
                        //    {
                        //        return;
                        //    }
                            if (!pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().slotFilled)
                            {
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().slotFilled = true;
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                                placedScarletPieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().prefab = placedScarletPieces[scarletPlacedCount];
                                scarletPlacedCount++;
                                break;
                            }
                        }
                        break;
                    case 2:
                        print("Eddie Evidence Placed");
                        for (eddieCount = 0; eddieCount < 8; eddieCount++)
                        {
                        //    if (pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().slotFilled)
                      //      {
                       //         return;
                         //   }
                            if (!pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().slotFilled)
                            {
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().slotFilled = true;
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                                placedEddiePieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().prefab = placedEddiePieces[eddiePlacedCount];
                                eddiePlacedCount++;
                                break;
                            }
                        }
                        break;
                    case 3:
                        print("Juice Box Evidence Placed");
                        for (juiceBoxCount = 0; juiceBoxCount < 8; juiceBoxCount++)
                        {
                          //  if (pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().slotFilled)
                          //  {
                          //      return;
                          //  }
                            if (!pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().slotFilled)
                            {
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().slotFilled = true;
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                                placedJuiceBoxPieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().prefab = placedJuiceBoxPieces[juiceBoxPlacedCount];
                                juiceBoxPlacedCount++;
                                break;
                            }
                        }
                        break;
                    case 4:
                        print("Grace Evidence Placed");
                        for (graceCount = 0; graceCount < 8; graceCount++)
                        {
                         //   if (pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().slotFilled)
                         //   {
                          //      return;
                          //  }
                            if (!pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().slotFilled)
                            {
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().slotFilled = true;
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                                placedGracePieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().prefab = placedGracePieces[gracePlacedCount];
                                gracePlacedCount++;
                                break;
                            }
                        }
                        break;
                }
                //pinboardManager.GetComponent<PinboardManager>().correctConclusions++;
                //pinboardManager.GetComponent<PinboardManager>().evidencePiecesPlaced++;
                //pinboardManager.GetComponent<PinboardManager>().CalculateAnswerPercentages();
            }
            else if (eventData.pointerDrag.GetComponent<DragAndDrop>().itemID < slotID || eventData.pointerDrag.GetComponent<DragAndDrop>().itemID > slotID)
            {
                Debug.Log("Incorrect Slot");
                //pinboardManager.GetComponent<PinboardManager>().incorrectConclusions++;
                //pinboardManager.GetComponent<PinboardManager>().evidencePiecesPlaced++;
                //pinboardManager.GetComponent<PinboardManager>().CalculateAnswerPercentages();
                switch (slotID) //SWITCH STATEMENT REUIRED MAJOR REWORKING FOR EFFICIENCY
                {
                    case 0:
                        print("Chase Evidence Placed");
                        for (chaseCount = 0; chaseCount < 8; chaseCount++)
                        {
                          //  if (pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().slotFilled)
                           // {
                           //     return;
                           // }
                            if (!pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().slotFilled)
                            {
                                pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                                pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().slotFilled = true;
                                pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                                pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                                placedChasePieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                                pinboardManager.GetComponent<PinboardManager>().chaseEvidenceSlots[chaseCount].GetComponent<EvidenceSlot>().prefab = placedChasePieces[chasePlacedCount];
                                chasePlacedCount++;
                                break;
                            }
                        }
                        break;
                    case 1:
                        print("Scarlet Evidence Placed");
                        for (scarletCount = 0; scarletCount < 8; scarletCount++)
                        {
                           // if (pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().slotFilled)
                           // {
                          //      return;
                          //  }
                            if (!pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().slotFilled)
                            {
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().slotFilled = true;
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                                placedScarletPieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                                pinboardManager.GetComponent<PinboardManager>().scarletEvidenceSlots[scarletCount].GetComponent<EvidenceSlot>().prefab = placedScarletPieces[scarletPlacedCount];
                                scarletPlacedCount++;

                                break;
                            }
                        }
                        break;
                    case 2:
                        print("Eddie Evidence Placed");
                        for (eddieCount = 0; eddieCount < 8; eddieCount++)
                        {
                            //if (pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().slotFilled)
                          //  {
                               // return;
                         //   }
                            if (!pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().slotFilled)
                            {
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().slotFilled = true;
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                                print("Placing 2nd");
                                placedEddiePieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                                
                                pinboardManager.GetComponent<PinboardManager>().eddieEvidenceSlots[eddieCount].GetComponent<EvidenceSlot>().prefab = placedEddiePieces[eddiePlacedCount];
                                eddiePlacedCount++;
                                break;
                            }
                            
                        }
                        break;
                    case 3:
                        print("Juice Box Evidence Placed");
                        for (juiceBoxCount = 0; juiceBoxCount < 8; juiceBoxCount++)
                        {
                           // if (pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().slotFilled)
                            //{
                             //   return;
                           // }
                            if (!pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().slotFilled)
                            {
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().slotFilled = true;
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                                placedJuiceBoxPieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                                pinboardManager.GetComponent<PinboardManager>().juiceBoxEvidenceSlots[juiceBoxCount].GetComponent<EvidenceSlot>().prefab = placedJuiceBoxPieces[juiceBoxPlacedCount];
                                juiceBoxPlacedCount++;
                                break;
                            }
                        }
                        break;

                    case 4:
                        print("Grace Evidence Placed");
                        for (graceCount = 0; graceCount < 8; graceCount++)
                        {
                          //  if (pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().slotFilled)
                           // {
                           //     return;
                          //  }
                            if (!pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().slotFilled)
                            {
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().slotFilled = true;
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().evidenceText = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceText;
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().evidenceID = eventData.pointerDrag.GetComponent<EvidenceClass>().evidenceID;
                                placedGracePieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
                                pinboardManager.GetComponent<PinboardManager>().graceEvidenceSlots[graceCount].GetComponent<EvidenceSlot>().prefab = placedGracePieces[gracePlacedCount];
                                gracePlacedCount++;
                                break;
                            }
                        }
                        break;
                }

            }

            eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab.GetComponent<Image>().maskable = true;
            //placedScarletPieces.Add(Instantiate(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab, content));
            Destroy(eventData.pointerDrag.GetComponent<DragAndDrop>().itemPrefab);

            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }

    }

}
