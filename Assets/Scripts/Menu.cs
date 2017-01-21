using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public AudioSource hoverSound;
    public Canvas MainMenuCanvas;
    public Canvas OptionCanvas;

    private void Awake()
    {
        OptionCanvas.enabled = false;
    }

    public void OptionsOn()
    {
        OptionCanvas.enabled = true;
        MainMenuCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        OptionCanvas.enabled = false;
        MainMenuCanvas.enabled = true;
    }

    public void LoadOn()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayHover()
    {
        AudioSource audio = hoverSound;
        audio.Play();
    }

}
