using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadUI : MonoBehaviour
{
    public GameObject imgDEAD;
    public GameObject scoreUI;
    public GameObject jumpScript;
    public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        dead = true;
        imgDEAD.SetActive(false);
        scoreUI.SetActive(true);
        jumpScript.GetComponent<JumpVelocity>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        // print("show");
        imgDEAD.SetActive(true);
        scoreUI.SetActive(false);
        jumpScript.GetComponent<JumpVelocity>().enabled = false;

        if (Input.GetKey(KeyCode.Space))
        {
            dead = false;
            SceneManager.LoadScene("MainScene");
        }
    }
}
