using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Screens
    private GameObject mainMenuHomeScreen;
    private GameObject mainMenuOptionsScreen;
    private GameObject mainMenuCreditsScreen;

    void Awake()
    {
        // Screens
        mainMenuHomeScreen = GameObject.Find("MainMenuHomeScreen");
        mainMenuOptionsScreen = GameObject.Find("MainMenuOptionsScreen");
        mainMenuCreditsScreen = GameObject.Find("MainMenuCreditsScreen");
    }

    // Start is called before the first frame update
    void Start()
    {
        // Screens
        mainMenuHomeScreen.SetActive(true);
        mainMenuOptionsScreen.SetActive(false);
        mainMenuCreditsScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ToPRIMESTEM()
    {
        Application.OpenURL("https://linktr.ee/primestemtrioucf");
    }

    public void ToOptions()
    {
        mainMenuHomeScreen.SetActive(false);
        mainMenuOptionsScreen.SetActive(true);
        mainMenuCreditsScreen.SetActive(false);
    }

    public void ToCredits()
    {
        mainMenuHomeScreen.SetActive(false);
        mainMenuOptionsScreen.SetActive(false);
        mainMenuCreditsScreen.SetActive(true);
    }

    public void BackToMainMenu()
    {
        mainMenuHomeScreen.SetActive(true);
        mainMenuOptionsScreen.SetActive(false);
        mainMenuCreditsScreen.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
