using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public static GameManager inst;
    public Text scoreText;
    public PlayerMovement playerMovement;

    public void IncrementScore(){
        score++;
        scoreText.text = "SCORE: " + score;

        // Increase player movement
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }
    public void Awake(){
        inst = this;
    }
}
