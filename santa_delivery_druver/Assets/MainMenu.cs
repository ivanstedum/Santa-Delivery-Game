using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mode;
    // Start is called before the first frame update
    public void PlayGame()
    {
        if(mode.tag == "easy")
        {
            SceneManager.LoadScene("easy");

        }
        if(mode.tag == "medium")
        {
            SceneManager.LoadScene("medium");
        }
        if(mode.tag == "hard")
        {
            SceneManager.LoadScene("SampleScene");
        }
            
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Main Menu");
    }
    // Update is called once per frame
    public void QuitGame()
    {
            
        Application.Quit();

    }

}
