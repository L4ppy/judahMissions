using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayScore : MonoBehaviour {


    private GameObject scoreManagerObject;
    private Score scoreScript;
    public TMP_Text scoreText;    
    private string scoreToDisplay;


    // Start is called before the first frame update
    void Start() {
        scoreManagerObject = GameObject.Find("_ScoreManager");

        scoreScript = scoreManagerObject.GetComponent<Score>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Reading current score as " + scoreScript.currentScore);

        scoreToDisplay = "Score: " + scoreScript.currentScore + "";
        scoreText.text = scoreToDisplay;
    }
}
