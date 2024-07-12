using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    
   
    public static ScoreManager instance;
    public TextMeshProUGUI scoreLabel;
    public TextMeshProUGUI Re;
    private int currentscore;

    public int yass;
    
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    void Start()
    {
        SetScoreLabel(currentscore);
    }

    public void AddScore()
    {
        currentscore++;
        SetScoreLabel(currentscore);
    }

    public void SetScoreLabel(int score)
    {
        scoreLabel.text = "Score : " + score;
        Re.text = "Score : " + score;
        yass = score;

        
    }

    
}
