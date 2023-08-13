using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void PlayButton ()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void StoryButton()
    {
        SceneManager.LoadScene(6);
    }

    public void ControlsButton()
    {
        SceneManager.LoadScene(7);
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene(8);
    }

    public void QuitButton ()
    {
        Application.Quit();
    }
}
