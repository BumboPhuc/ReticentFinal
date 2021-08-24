﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public HealthBar healthbar;

    public void Setup()
    {
        gameObject.SetActive(true);

    }

    public bool isPaused = false;

    public void SwitchPauseDeath()
    {
        Time.timeScale = Time.timeScale == 1 ? 0 : 1;
        isPaused = isPaused = true ? false : true;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SwitchPauseDeath();
    }

    public void Menu()
    {
        SceneManager.LoadScene("TitleScreen");
        SwitchPauseDeath();
    }
}