using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private GameObject menu;
    private GameObject gamePlayHud;
    private GameObject levelSelect;
    private GameObject gameOverMenu;
    private GameObject creditsMenu;
    public bool menuOn;

    // Use this for initialization
    void Start()
    {
        menu = GameObject.Find("Menu");
        gamePlayHud = GameObject.Find("GamePlayHUD");
        levelSelect = GameObject.Find("LevelSelectMenu");
        gameOverMenu = GameObject.Find("GameOverMenu");
        creditsMenu = GameObject.Find("CreditsMenu");

        gamePlayHud.SetActive(false);
        levelSelect.SetActive(false);
        gameOverMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            ShowMenu(true);
        }
    }

    public void ShowMenu(bool value)
    {
        // pause player
        WorldSingleton.main.player.PausePlayer(value);

        menu.SetActive(value);
        gamePlayHud.SetActive(!value);

        // Either we show menu or hud, but we don't care about level select or
        // game over menus
        levelSelect.SetActive(false);
        gameOverMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }

    public void ShowLevelSelectMenu()
    {
        menu.SetActive(false);
        gamePlayHud.SetActive(false);
        creditsMenu.SetActive(false);
        levelSelect.SetActive(true);
    }

    public bool MenuOn()
    {
        return menu.activeSelf;
    }

    public void GameOver()
    {
        menu.SetActive(false);
        creditsMenu.SetActive(false);
        gameOverMenu.SetActive(true);
    }

    public void ShowCredits()
    {
        menu.SetActive(false);
        creditsMenu.SetActive(true);
    }
}

