using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{

    public int playerScore = 0;
    public Text scoreText; 


    public void addScore(int scoreToAdd)
    {
        playerScore = scoreToAdd + playerScore;
        scoreText.text = playerScore.ToString();
    }


}//end class
