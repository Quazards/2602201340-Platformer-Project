using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreTxt;
   void Start()
    {
        scoreTxt.text = "Score: " + Scoring.score;
    }

   private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Point")
        {
            Scoring.score += 100;
            scoreTxt.text = "Score: " + Scoring.score;
            collider.gameObject.SetActive(false);
        }
    }
}
