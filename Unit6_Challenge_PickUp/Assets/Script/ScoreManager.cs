using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text Mesh Pro name spaced added tp access the librarys for UI

public class ScoreManager : MonoBehaviour
{
    public int score; // Keep our score value
    

    public TextMeshProUGUI scoreText; // Visual text element to be modified

    public void IncreaseScore(int amount) // This method when called increases the score by a predetermined amount set in score variable
    {
        score += amount;
        UpdateScoreText();

    }

    public void DecreaseScore(int amount) // This method when called decreases the score by a predetermined amount set in score variable
    {
        score -= amount;
        UpdateScoreText();

    }

    public void UpdateScoreText() // This method updates the score in the HUD UI text
    {
        scoreText = "Score: " + score;
    }
}
