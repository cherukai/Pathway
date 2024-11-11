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
    string Lives = "Lives: ";

    void Start()
    {
        livesText.text = playerLives.ToString(Lives + playerLives);
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
        livesText.text = playerLives.ToString(Lives + (playerLives -= 1));
    }
}
