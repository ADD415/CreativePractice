using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Image blackFade; //Image used as a fader for transition to main game 
    int timeToFade = 1; //Time to fade to black
    public AudioSource sfxManager; //Audio source for start menu
    public AudioClip selectChoice; //Sound used for choosing an option

    public GameObject optionsMenu; // shows after clicking options/settings
    public GameObject graphicsMenu; //UI element for graphics settings menu
    public GameObject resMenu; // shows resolution menu
    public GameObject audioMenu; // open audio menu
    public GameObject colourblindMenu; // open colourblind menu
    public GameObject controlsUI; // UI image of controls

    bool optionsOpen;

    public void Begin() //Used when the player starts the game
    {
        blackFade.gameObject.SetActive(true); 
        sfxManager.PlayOneShot(selectChoice, 0.4f); //Plays relevant sound 
        StartCoroutine(FadeToBlack()); //Begins black fade

        if(optionsMenu.activeInHierarchy)
        {
            ToggleOptions();
        }
        
        if(graphicsMenu.activeInHierarchy)
        {
            CloseGraphics(); //Closes settings menu
        }

        if(resMenu.activeInHierarchy)
        {
            CloseResMenu();
        }

        if(audioMenu.activeInHierarchy)
        {
            CloseAudioMenu();
        }

        if(colourblindMenu.activeInHierarchy)
        {
            CloseColourblindMenu();
        }
        
    }

    public IEnumerator FadeToBlack() //Coroutine similiar to scene transition one //Used to fade the screen to black
    {
        Color screenColour = blackFade.color;
        float fadeProgress;
        
            while (blackFade.color.a < 1)
            {
                fadeProgress = screenColour.a + (timeToFade * Time.deltaTime);
                screenColour = new Color(screenColour.r, screenColour.g, screenColour.b, fadeProgress);
                blackFade.color = screenColour;
                if(fadeProgress > 0.9999f)
            {
                SceneManager.LoadScene("MainScene");
                Cursor.visible = false;
            }

                yield return null;
            }
        
        
    }

    public void ToggleOptions()
    {
        sfxManager.PlayOneShot(selectChoice, 0.4f);
        if(!optionsMenu.activeInHierarchy)
        {
            optionsOpen = false;
        }

        if(optionsOpen = !optionsOpen)
        {
            optionsOpen = true;
            optionsMenu.SetActive(true);
        }
        else
        {
            optionsOpen = false;
            optionsMenu.SetActive(false);
        }

        if(graphicsMenu.activeInHierarchy)
        {
            graphicsMenu.SetActive(false);
        }

        if(resMenu.activeInHierarchy)
        {
            resMenu.SetActive(false);
        }

        if(audioMenu.activeInHierarchy)
        {
            audioMenu.SetActive(false);
        }

        if(colourblindMenu.activeInHierarchy)
        {
            colourblindMenu.SetActive(false);
        }

        if(controlsUI)
        {
            if(controlsUI.activeInHierarchy && optionsOpen == true)
            {
                controlsUI.SetActive(false);
            }
        }

    }

    public void OpenResolutionMenu()
    {
        sfxManager.PlayOneShot(selectChoice, 0.4f);
        resMenu.SetActive(true);

        if(controlsUI)
        {
            if(controlsUI.activeInHierarchy)
            {
                controlsUI.SetActive(false);
            }
        }

        if(graphicsMenu.activeInHierarchy)
        {
            graphicsMenu.SetActive(false);
        }

        if(audioMenu.activeInHierarchy)
        {
            audioMenu.SetActive(false);
        }

        if(colourblindMenu.activeInHierarchy)
        {
            colourblindMenu.SetActive(false);
        }
    }

    public void CloseResMenu()
    {
        sfxManager.PlayOneShot(selectChoice, 0.4f);
        resMenu.SetActive(false);
    }

    public void OpenAudioMenu()
    {
        sfxManager.PlayOneShot(selectChoice, 0.4f);
        audioMenu.SetActive(true);

        if(controlsUI)
        {
            if(controlsUI.activeInHierarchy)
            {
                controlsUI.SetActive(false);
            }
        }

        if(graphicsMenu.activeInHierarchy)
        {
            graphicsMenu.SetActive(false);
        }

        if(resMenu.activeInHierarchy)
        {
            resMenu.SetActive(false);
        }

        if(colourblindMenu.activeInHierarchy)
        {
            colourblindMenu.SetActive(false);
        }
    }

    public void CloseAudioMenu()
    {
        sfxManager.PlayOneShot(selectChoice, 0.4f);
        audioMenu.SetActive(false);
    }

    public void Graphics() //Opens graphics settings menu
    {
        graphicsMenu.SetActive(true);
        sfxManager.PlayOneShot(selectChoice, 0.4f);

        if(controlsUI)
        {
            if(controlsUI.activeInHierarchy)
            {
                controlsUI.SetActive(false);
            }
        }

        if(resMenu.activeInHierarchy)
        {
            resMenu.SetActive(false);
        }

        if(audioMenu.activeInHierarchy)
        {
            audioMenu.SetActive(false);
        }

        if(colourblindMenu.activeInHierarchy)
        {
            colourblindMenu.SetActive(false);
        }
    }

    public void CloseGraphics() //Closes graphics settings menu
    {
        graphicsMenu.SetActive(false);
        sfxManager.PlayOneShot(selectChoice, 0.4f);
    }

    // Shows controls image when clicking on "Controls" in the gameplay menu
    public void OpenControlsUI()
    {
        controlsUI.SetActive(true);
        
        if(graphicsMenu.activeInHierarchy)
        {
            graphicsMenu.SetActive(false);
        }

        if(resMenu.activeInHierarchy)
        {
            resMenu.SetActive(false);
        }

        if(audioMenu.activeInHierarchy)
        {
            audioMenu.SetActive(false);
        }

        if(colourblindMenu.activeInHierarchy)
        {
            colourblindMenu.SetActive(false);
        }

        if(optionsMenu.activeInHierarchy)
        {
            ToggleOptions();
        }
    }

    public void OpenColourblindMenu()
    {
        sfxManager.PlayOneShot(selectChoice, 0.4f);
        colourblindMenu.SetActive(true);

        if(controlsUI)
        {
            if(controlsUI.activeInHierarchy)
            {
                controlsUI.SetActive(false);
            }
        }

        if(graphicsMenu.activeInHierarchy)
        {
            graphicsMenu.SetActive(false);
        }

        if(resMenu.activeInHierarchy)
        {
            resMenu.SetActive(false);
        }

        if(audioMenu.activeInHierarchy)
        {
            audioMenu.SetActive(false);
        }
    }

    public void CloseColourblindMenu()
    {
        sfxManager.PlayOneShot(selectChoice, 0.4f);
        colourblindMenu.SetActive(false);
    }

    public void QuitGame() //Quits the game 
    {
        sfxManager.PlayOneShot(selectChoice, 0.4f);
       // if(UnityEngine.Application.isEditor)
      //  {
       //     UnityEditor.EditorApplication.isPlaying = false;
            
      //  }
       // else
       // {
            Application.Quit();
       // }
    }
}
