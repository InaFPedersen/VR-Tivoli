using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    //Variables:
    public static PlayerScore instance;

    [Header("Score")]
    public TextMeshProUGUI scoreText;
    public int scorePoints;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scorePoints = 0;
        scoreText.text = "Score: " + scorePoints + " points!";
    }

    public void AddPoints()
    {
        scorePoints++;
        scoreText.text = "Score: " + scorePoints + " points!";
    }
    
}
