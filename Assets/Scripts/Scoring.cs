using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{  
    public Text Scoretext;
    public int Score = 0;
    public int maxScore;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }
    
    public void AddScore(int newScore)
    {
        Score += newScore;
    }

     public void UpdateScore()
    {
        Scoretext.text = "Score 0" + Score;
    }


    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }
}
