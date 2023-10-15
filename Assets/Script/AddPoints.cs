using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddPoints : MonoBehaviour
{
    public TMP_Text scoreUI;
    public TMP_Text deadUI;
    private int score = 0;

    public int Get()
    {
        return score;
    }

    public void Set(int score_)
    {
        score = score_;
        // print(score); 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
        deadUI.text = score.ToString();
    }
}


//restrict jump times per platform
//in jumpvelocity
//if after jump addpoints score same as previous jump
//gameover