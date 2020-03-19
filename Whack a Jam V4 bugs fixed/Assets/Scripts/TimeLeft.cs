using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLeft : MonoBehaviour
{
   // private Text TimeText;
    public Animator Canvas;
    public Slider Timer;
    public float timeremain;

    // Start is called before the first frame update
    void Start()
    {
        //TimeText = GetComponent<Text>();
        Timer.value = Timer.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Scores.win == false)
        {
            timeremain -= Time.deltaTime;
            if (timeremain <= 0)
            {
                SceneManager.LoadScene("Game over");//Loads game over screen
                timeremain = 0;
            }
        }
        Timer.value = timeremain;        
        if (Scores.win == true)
        {
            timeremain = timeremain;
        }
    }
}
