using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadUI : MonoBehaviour
{
    public GameObject imgDEAD;
    public GameObject scoreUI;

    // Start is called before the first frame update
    void Start()
    {
        imgDEAD.SetActive(false);
        scoreUI.SetActive(true);
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
    }
}
