using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //[SerializeField] int sceneBuildIndex;
    
    private Quiz _quiz;
    private EndScreen _endScreen;

    private bool _gamePaused = false;


    private void Awake()
    {
        _quiz = FindObjectOfType<Quiz>();
        _endScreen = FindObjectOfType<EndScreen>();
    }

    void Start()
    {
        _quiz.gameObject.SetActive(true);
        _endScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_quiz.isComplete)
        {
            _quiz.gameObject.SetActive(false);
            _endScreen.gameObject.SetActive(true);
            _endScreen.ShowFinalScore();
        }
    }

    public void PauseGame()
    {
        if (!_gamePaused)
        {
            Time.timeScale = 0;
            _gamePaused = true;
            return;
        }

        if (_gamePaused)
        {
            Time.timeScale = 1;
            _gamePaused = false;
            return;
        }
        
    }
    
    public void ReturnToBackPage()
    {
        SceneManager.LoadScene("MathLevel");
    }

    public void ReturnToHome()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
