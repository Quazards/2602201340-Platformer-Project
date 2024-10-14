using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text heartScore;
    //public Text emojiScore;
    public GameManagerScript gameManager;
    private bool isFinished;
   void Start()
    {
        Scoring.score = 0;
         heartScore.gameObject.SetActive(false);
        //emojiScore.gameObject.SetActive(false);
    }

    void Update()
    {
        if(Scoring.score == 1000 && !isFinished)
        {
            isFinished = true;
            gameManager.gameOver();
            gameObject.SetActive(false);
        }
    }

   private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Point")
        {
             heartScore.gameObject.SetActive(true);
            Scoring.score += 100;
            heartScore.text = "Heart Score: " + Scoring.score;
            collider.gameObject.SetActive(false);
        }
        else if(collider.tag == "Emoji")
        {
            //emojiScore.gameObject.SetActive(true);
            Scoring.emojiScore += 100;
            //emojiScore.text = "Emoji Score: " + Scoring.emojiScore;
            collider.gameObject.SetActive(false);   
        }
    }
}
