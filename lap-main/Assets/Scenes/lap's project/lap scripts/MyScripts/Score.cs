using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int currentScore = 0;
    public void updateScore(int scoreToAdd)
    {
        Debug.Log("Reading scoreToAdd as " + scoreToAdd);
        currentScore = currentScore + scoreToAdd;
        Debug.Log("Reading currentScore as " + currentScore);
    }
   
}
