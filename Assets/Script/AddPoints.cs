using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddPoints : MonoBehaviour
{
    // bool isTouched = false;
    public TMP_Text scoreUI;
    private int score = -1;

    // void OnCollisionEnter(Collision target) { 
    //     if (target.gameObject.tag == "platform")  {  
    //             // print("before" + isTouched);
    //             score += 1;
    //             print(score); 
    //             // isTouched = true;
    //             // print("after" + isTouched);
    //     }  
    // }  

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
    }
}


//restrict jump times per platform
//in jumpvelocity
//if after jump addpoints score same as previous jump
//gameover