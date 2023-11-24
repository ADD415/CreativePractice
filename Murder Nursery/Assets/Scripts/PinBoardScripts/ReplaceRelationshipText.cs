using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

// attached to story evidence text for replacing [?????] in the characters story
public class ReplaceRelationshipText : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    Transform content;

    Transform scarletStory;
    Transform juiceBoxStory;
    Transform eddieStory;
    Transform chaseStory;
    Transform graceStory;

    private PinboardManager PM;

    string textToReplace;
    string replacingText;

    private void Start()
    {
        PM = FindObjectOfType<PinboardManager>();
    }

    // Updates unknown story text (?????) with the text clicked on from the story evidence panel
    void UpdateStoryText(string storyString, Transform story, string objectName)
    {
        // finds the child content relating to the string passed in & checks that object text being replaced is the same as the objectName passed in
        if(content.Find(storyString) && PM.objectNameBeingReplaced == objectName)
        {
            Debug.Log(storyString);
            story = content.Find(storyString);
            foreach (Transform item in story)
            {
                if(item.GetComponent<OpenRelationshipOptionsPanel>())
                {
                    string name = item.GetComponent<OpenRelationshipOptionsPanel>().name;
                    if(name == objectName)
                    {
                        textToReplace = item.GetComponent<TextMeshProUGUI>().text;

                        // updates the text clicked on from the story with the text clicked on from the story evidence panel
                        item.GetComponent<TextMeshProUGUI>().text = item.GetComponent<TextMeshProUGUI>().text.Replace(textToReplace, replacingText);
                        break;
                    }
                }
            }

        }
    }

    // Called when text is clicked from story evidence panel
    public void OnPointerClick(PointerEventData eventData)
    {
        replacingText = gameObject.GetComponent<TextMeshProUGUI>().text;

        UpdateStoryText("ScarletStory", scarletStory, "ScarletOne");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletTwo");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletThree");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletFour");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletFive");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletSix");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletSeven");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletEight");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletNine");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletTen");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletEleven");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletTwelve");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletThirteen");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletFourteen");
        UpdateStoryText("ScarletStory", scarletStory, "ScarletFifteen");

        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxOne");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxTwo");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxThree");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxFour");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxFive");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxSix");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxSeven");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxEight");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxNine");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxTen");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxEleven");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxTwelve");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxThirteen");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxFourteen");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxFifteen");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxSixteen");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxSeventeen");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxEighteen");
        UpdateStoryText("JuiceBoxStory", juiceBoxStory, "JuiceBoxNineteen");

        UpdateStoryText("ChaseStory", chaseStory, "ChaseOne");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseTwo");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseThree");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseFour");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseFive");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseSix");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseSeven");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseEight");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseNine");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseTen");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseEleven");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseTwelve");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseThirteen");
        UpdateStoryText("ChaseStory", chaseStory, "ChaseFourteen");

        UpdateStoryText("EddieStory", eddieStory, "EddieOne");
        UpdateStoryText("EddieStory", eddieStory, "EddieTwo");
        UpdateStoryText("EddieStory", eddieStory, "EddieThree");
        UpdateStoryText("EddieStory", eddieStory, "EddieFour");
        UpdateStoryText("EddieStory", eddieStory, "EddieFive");
        UpdateStoryText("EddieStory", eddieStory, "EddieSix");
        UpdateStoryText("EddieStory", eddieStory, "EddieSeven");
        UpdateStoryText("EddieStory", eddieStory, "EddieEight");
        UpdateStoryText("EddieStory", eddieStory, "EddieNine");
        UpdateStoryText("EddieStory", eddieStory, "EddieTen");
        UpdateStoryText("EddieStory", eddieStory, "EddieEleven");
        UpdateStoryText("EddieStory", eddieStory, "EddieTwelve");
        UpdateStoryText("EddieStory", eddieStory, "EddieThirteen");
        UpdateStoryText("EddieStory", eddieStory, "EddieFourteen");
        UpdateStoryText("EddieStory", eddieStory, "EddieFifteen");
        UpdateStoryText("EddieStory", eddieStory, "EddieSixteen");

        UpdateStoryText("GraceStory", graceStory, "GraceOne");
        UpdateStoryText("GraceStory", graceStory, "GraceTwo");
        UpdateStoryText("GraceStory", graceStory, "GraceThree");
        UpdateStoryText("GraceStory", graceStory, "GraceFour");
        UpdateStoryText("GraceStory", graceStory, "GraceFive");
        UpdateStoryText("GraceStory", graceStory, "GraceSix");
        UpdateStoryText("GraceStory", graceStory, "GraceSeven");
        UpdateStoryText("GraceStory", graceStory, "GraceEight");
        UpdateStoryText("GraceStory", graceStory, "GraceNine");
        UpdateStoryText("GraceStory", graceStory, "GraceTen");
        UpdateStoryText("GraceStory", graceStory, "GraceEleven");
        UpdateStoryText("GraceStory", graceStory, "GraceTwelve");
        UpdateStoryText("GraceStory", graceStory, "GraceThirteen");
        UpdateStoryText("GraceStory", graceStory, "GraceFourteen");
        UpdateStoryText("GraceStory", graceStory, "GraceFifteen");
        UpdateStoryText("GraceStory", graceStory, "GraceSixteen");
        UpdateStoryText("GraceStory", graceStory, "GraceSeventeen");
   
    }
}
