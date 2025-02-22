﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//  UnityEngine.UI so Text class is avalbile 
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

   [SerializeField]
    private Text _scoreText;
    [SerializeField]
    private Image _LivesImg;
    [SerializeField]
    private Sprite[] _liveSprites;
    [SerializeField]
    private Text _gameOverText;
    [SerializeField]
    private Text _rToRestartText;
    // ref to GameManager so GameOver() works
    private GameManager _gameManager;
  
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score: " + 0 ;
        // at start of game no game over text
        _gameOverText.gameObject.SetActive(false);
        // assign the handle to component 
        _gameManager=GameObject.Find("Game_Manager").GetComponent<GameManager>();
    
        if (_gameManager == null)
        {
            Debug.LogError("GameManager is Null");
        }
       
    }

    // method to call from player.cs
    public void UpdateScore(int playerScore) {

        _scoreText.text = "Score: " + playerScore.ToString();
    }
    // system to update lives - call from player.cs 
    public void UpdateLives(int currentLives)
    {
        // display img sprite based on currentlives index
             _LivesImg.sprite = _liveSprites[currentLives];
       if (currentLives==0)
        {
            GameOverSequence();
        }
    }
    // giving management of game over its own method 
    void GameOverSequence()
     {
        _gameManager.GameOver();
        _gameOverText.gameObject.SetActive(true);
        // activate the restart text 
        _rToRestartText.gameObject.SetActive(true);
        // coroutine with the while loop
        StartCoroutine(GameOverFlickerRoutine());
    }
   IEnumerator GameOverFlickerRoutine()
    {
        while (true)
        {
           _gameOverText.text = "Game Over";
            yield return new WaitForSeconds(0.5f);
            _gameOverText.text = "";
            yield return new WaitForSeconds(0.5f);
        }  
    }
}
