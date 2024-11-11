using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    string ScoreWord = "Score: ";

    void Start()
    {
        scoreText.text = score.ToString(ScoreWord + score);
    }


    public void ScorePlusOne()
    {
        if (score >= 0)
        {
            ScoreIncrease();
        }
    }


    void ScoreIncrease()
    {
        scoreText.text = score.ToString(ScoreWord + (score += 1));
    }
}