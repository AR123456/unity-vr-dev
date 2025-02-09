﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// need this namespace for the scenemanager
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // by default isGameOver is false
    [SerializeField]
    private bool _isGameOver;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && _isGameOver==true)
        {
            // can be scene index or scene name
            SceneManager.LoadScene(1);// index 1 is "Game"
        }
        // if escape key is pressed quit application 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


     }
    // method to call game over from the UIManager.cs  GameOverSequennce
    public void GameOver()
    {
           _isGameOver = true;
    }
}
