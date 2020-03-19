using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    public static int scoreAmount; // Holds player score need to win 

    public Animator Canvas;//??
    public Slider ScoreBar;

    public int goal;//Holds target score to win
    public static bool win;//Identifys if player has won

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
        win = false;
        ScoreBar.maxValue = goal;
        ScoreBar.value = 0;//Set the max value on slider
    }

    // Update is called once per frame
    void Update()
    {
        ScoreBar.value = scoreAmount;
        if (scoreAmount >= goal)//Checks if player has reached the goal
        {
            SceneManager.LoadScene("Victory");
            win = true;//Changed win state to true
        }
    }
}
