using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpManager : MonoBehaviour
{
    private float currentCountdownValue;
    public void FadeImage(Image icon, GameObject text)
    {
        icon.gameObject.SetActive(true);
        StartCoroutine(FadeIcon(icon, true, text));
        StartCoroutine(WaitForSeconds(2, icon, text));

    }

    private IEnumerator FadeIcon(Image icon, bool fadeIn, GameObject text, int timeToFade = 1)
    {
        Color iconColour = icon.color;
        float fadeProgress;
        if(fadeIn)
        {
            
            while(icon.color.a < 1)
            {
                fadeProgress = iconColour.a + (timeToFade * Time.deltaTime);
                iconColour = new Color(iconColour.r, iconColour.g, iconColour.b, fadeProgress);
                icon.color = iconColour;
                if(fadeProgress >= 0.5)
                {
                    text.SetActive(true);
                }
                yield return null;
            }
        }
        else if(!fadeIn)
        {
            while(icon.color.a > 0)
            {
                fadeProgress = iconColour.a - (timeToFade * Time.deltaTime);
                iconColour = new Color(iconColour.r, iconColour.g, iconColour.b, fadeProgress);
                icon.color = iconColour;
                if(fadeProgress <= 0.5)
                {
                    text.SetActive(false);
                }
                if(fadeProgress <=0.01)
                {
                    icon.gameObject.SetActive(false);
                }
                yield return null;
            }
        }
    }

    private IEnumerator WaitForSeconds(float countdownValue, Image icon, GameObject text)
    {
        currentCountdownValue = countdownValue;
        while(currentCountdownValue > 0)
        {
            yield return new WaitForSeconds(1);
            currentCountdownValue--;
        }
        StartCoroutine(FadeIcon(icon, false, text));
    }
}
