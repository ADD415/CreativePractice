using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// when the players clicks on [?????] in the story content, it shows a list of evidence which can be chosen to replace the [?????] text with
public class OpenRelationshipOptionsPanel : MonoBehaviour, IPointerClickHandler
{
    PinboardManager PM;

    [Header("Scarlet")]
    [SerializeField]
    GameObject scarletOne;
    [SerializeField]
    GameObject scarletTwo;
    [SerializeField]
    GameObject scarletThree;
    [SerializeField]
    GameObject scarletFour;
    [SerializeField]
    GameObject scarletFive;
    [SerializeField]
    GameObject scarletSix;
    [SerializeField]
    GameObject scarletSeven;
    [SerializeField]
    GameObject scarletEight;
    [SerializeField]
    GameObject scarletNine;
    [SerializeField]
    GameObject scarletTen;
    [SerializeField]
    GameObject scarletEleven;
    [SerializeField]
    GameObject scarletTwelve;
    [SerializeField]
    GameObject scarletThirteen;
    [SerializeField]
    GameObject scarletFourteen;
    [SerializeField]
    GameObject scarletFifteen;

    [Header("Juice Box")]
    [SerializeField]
    GameObject juiceBoxOne;
    [SerializeField]
    GameObject juiceBoxTwo;
    [SerializeField]
    GameObject juiceBoxThree;
    [SerializeField]
    GameObject juiceBoxFour;
    [SerializeField]
    GameObject juiceBoxFive;
    [SerializeField]
    GameObject juiceBoxSix;
    [SerializeField]
    GameObject juiceBoxSeven;
    [SerializeField]
    GameObject juiceBoxEight;
    [SerializeField]
    GameObject juiceBoxNine;
    [SerializeField]
    GameObject juiceBoxTen;
    [SerializeField]
    GameObject juiceBoxEleven;
    [SerializeField]
    GameObject juiceBoxTwelve;
    [SerializeField]
    GameObject juiceBoxThirteen;
    [SerializeField]
    GameObject juiceBoxFourteen;
    [SerializeField]
    GameObject juiceBoxFifteen;
    [SerializeField]
    GameObject juiceBoxSixteen;
    [SerializeField]
    GameObject juiceBoxSeventeen;
    [SerializeField]
    GameObject juiceBoxEighteen;
    [SerializeField]
    GameObject juiceBoxNineteen;

    [Header("Chase")]
    [SerializeField]
    GameObject chaseOne;
    [SerializeField]
    GameObject chaseTwo;
    [SerializeField]
    GameObject chaseThree;
    [SerializeField]
    GameObject chaseFour;
    [SerializeField]
    GameObject chaseFive;
    [SerializeField]
    GameObject chaseSix;
    [SerializeField]
    GameObject chaseSeven;
    [SerializeField]
    GameObject chaseEight;
    [SerializeField]
    GameObject chaseNine;
    [SerializeField]
    GameObject chaseTen;
    [SerializeField]
    GameObject chaseEleven;
    [SerializeField]
    GameObject chaseTwelve;
    [SerializeField]
    GameObject chaseThirteen;
    [SerializeField]
    GameObject chaseFourteen;

    [Header("Eddie")]
    [SerializeField]
    GameObject eddieOne;
    [SerializeField]
    GameObject eddieTwo;
    [SerializeField]
    GameObject eddieThree;
    [SerializeField]
    GameObject eddieFour;
    [SerializeField]
    GameObject eddieFive;
    [SerializeField]
    GameObject eddieSix;
    [SerializeField]
    GameObject eddieSeven;
    [SerializeField]
    GameObject eddieEight;
    [SerializeField]
    GameObject eddieNine;
    [SerializeField]
    GameObject eddieTen;
    [SerializeField]
    GameObject eddieEleven;
    [SerializeField]
    GameObject eddieTwelve;
    [SerializeField]
    GameObject eddieThirteen;
    [SerializeField]
    GameObject eddieFourteen;
    [SerializeField]
    GameObject eddieFifteen;
    [SerializeField]
    GameObject eddieSixteen;

    [Header("Grace")]
    [SerializeField]
    GameObject graceOne;
    [SerializeField]
    GameObject graceTwo;
    [SerializeField]
    GameObject graceThree;
    [SerializeField]
    GameObject graceFour;
    [SerializeField]
    GameObject graceFive;
    [SerializeField]
    GameObject graceSix;
    [SerializeField]
    GameObject graceSeven;
    [SerializeField]
    GameObject graceEight;
    [SerializeField]
    GameObject graceNine;
    [SerializeField]
    GameObject graceTen;
    [SerializeField]
    GameObject graceEleven;
    [SerializeField]
    GameObject graceTwelve;
    [SerializeField]
    GameObject graceThirteen;
    [SerializeField]
    GameObject graceFourteen;
    [SerializeField]
    GameObject graceFifteen;
    [SerializeField]
    GameObject graceSixteen;
    [SerializeField]
    GameObject graceSeventeen;


    private void Start()
    {
        PM = FindObjectOfType<PinboardManager>();
    }

    // Called when ????? is clicked from story section on the pinboard
    public void OnPointerClick(PointerEventData eventData)
    {
        // sets the current object name we clicked on so we know which text to replace in "ReplaceRelationshipText" script
        PM.objectNameBeingReplaced = gameObject.name;

        UpdateStory("ScarletOne", scarletOne);
        UpdateStory("ScarletTwo", scarletTwo);
        UpdateStory("ScarletThree", scarletThree);
        UpdateStory("ScarletFour", scarletFour);
        UpdateStory("ScarletFive", scarletFive);
        UpdateStory("ScarletSix", scarletSix);
        UpdateStory("ScarletSeven", scarletSeven);
        UpdateStory("ScarletEight", scarletEight);
        UpdateStory("ScarletNine", scarletNine);
        UpdateStory("ScarletTen", scarletTen);
        UpdateStory("ScarletEleven", scarletEleven);
        UpdateStory("ScarletTwelve", scarletTwelve);
        UpdateStory("ScarletThirteen", scarletThirteen);
        UpdateStory("ScarletFourteen", scarletFourteen);
        UpdateStory("ScarletFifteen", scarletFifteen);

        UpdateStory("JuiceBoxOne", juiceBoxOne);
        UpdateStory("JuiceBoxTwo", juiceBoxTwo);
        UpdateStory("JuiceBoxThree", juiceBoxThree);
        UpdateStory("JuiceBoxFour", juiceBoxFour);
        UpdateStory("JuiceBoxFive", juiceBoxFive);
        UpdateStory("JuiceBoxSix", juiceBoxSix);
        UpdateStory("JuiceBoxSeven", juiceBoxSeven);
        UpdateStory("JuiceBoxEight", juiceBoxEight);
        UpdateStory("JuiceBoxNine", juiceBoxNine);
        UpdateStory("JuiceBoxTen", juiceBoxTen);
        UpdateStory("JuiceBoxEleven", juiceBoxEleven);
        UpdateStory("JuiceBoxTwelve", juiceBoxTwelve);
        UpdateStory("JuiceBoxThirteen", juiceBoxThirteen);
        UpdateStory("JuiceBoxFourteen", juiceBoxFourteen);
        UpdateStory("JuiceBoxFifteen", juiceBoxFifteen);
        UpdateStory("JuiceBoxSixteen", juiceBoxSixteen);
        UpdateStory("JuiceBoxSeventeen", juiceBoxSeventeen);
        UpdateStory("JuiceBoxEighteen", juiceBoxEighteen);
        UpdateStory("JuiceBoxNineteen", juiceBoxNineteen);

        UpdateStory("ChaseOne", chaseOne);
        UpdateStory("ChaseTwo", chaseTwo);
        UpdateStory("ChaseThree", chaseThree);
        UpdateStory("ChaseFour", chaseFour);
        UpdateStory("ChaseFive", chaseFive);
        UpdateStory("ChaseSix", chaseSix);
        UpdateStory("ChaseSeven", chaseSeven);
        UpdateStory("ChaseEight", chaseEight);
        UpdateStory("ChaseNine", chaseNine);
        UpdateStory("ChaseTen", chaseTen);
        UpdateStory("ChaseEleven", chaseEleven);
        UpdateStory("ChaseTwelve", chaseTwelve);
        UpdateStory("ChaseThirteen", chaseThirteen);
        UpdateStory("ChaseFourteen", chaseFourteen);

        UpdateStory("EddieOne", eddieOne);
        UpdateStory("EddieTwo", eddieTwo);
        UpdateStory("EddieThree", eddieThree);
        UpdateStory("EddieFour", eddieFour);
        UpdateStory("EddieFive", eddieFive);
        UpdateStory("EddieSix", eddieSix);
        UpdateStory("EddieSeven", eddieSeven);
        UpdateStory("EddieEight", eddieEight);
        UpdateStory("EddieNine", eddieNine);
        UpdateStory("EddieTen", eddieTen);
        UpdateStory("EddieEleven", eddieEleven);
        UpdateStory("EddieTwelve", eddieTwelve);
        UpdateStory("EddieThirteen", eddieThirteen);
        UpdateStory("EddieFourteen", eddieFourteen);
        UpdateStory("EddieFifteen", eddieFifteen);
        UpdateStory("EddieSixteen", eddieSixteen);

        UpdateStory("GraceOne", graceOne);
        UpdateStory("GraceTwo", graceTwo);
        UpdateStory("GraceThree", graceThree);
        UpdateStory("GraceFour", graceFour);
        UpdateStory("GraceFive", graceFive);
        UpdateStory("GraceSix", graceSix);
        UpdateStory("GraceSeven", graceSeven);
        UpdateStory("GraceEight", graceEight);
        UpdateStory("GraceNine", graceNine);
        UpdateStory("GraceTen", graceTen);
        UpdateStory("GraceEleven", graceEleven);
        UpdateStory("GraceTwelve", graceTwelve);
        UpdateStory("GraceThirteen", graceThirteen);
        UpdateStory("GraceFourteen", graceFourteen);
        UpdateStory("GraceFifteen", graceFifteen);
        UpdateStory("GraceSixteen", graceSixteen);
        UpdateStory("GraceSeventeen", graceSeventeen);

    }

    // Sets active object to view & select evidence to slot into the story
    void UpdateStory(string objectName, GameObject storyEvidence)
    {
        if (objectName == PM.objectNameBeingReplaced)
        {
            storyEvidence.SetActive(true);
        }
        else
        {
            storyEvidence.SetActive(false);
        }
    }
    
}
