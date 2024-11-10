using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{

    [SerializeField] int playerLives = 3;
    [SerializeField] TextMeshProUGUI livesText;

    void Start()
    {
        livesText.text = playerLives.ToString();
    }


    public void ProcessPlayerDeath()
    {
        if (playerLives > 0)
        {
            TakeLife();
        }
    }


    void TakeLife()
    {
        playerLives -= 1;
        livesText.text = playerLives.ToString();
    }
}
