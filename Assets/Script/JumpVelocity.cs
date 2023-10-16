using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpVelocity : MonoBehaviour
{
    public Rigidbody rb;
    // public float buttonTime;
    public float jumpAmount;

    bool jumping;

    public TMP_Text scoreUI;
    public TMP_Text levelUI;
    Vector3 currentEulerAngles;

    bool isKeyDown = false;

    void Start()
    {
        scoreUI = GameObject.Find("scoreText").GetComponent<TMP_Text>();
        levelUI = GameObject.Find("nameText").GetComponent<TMP_Text>();
        
        currentEulerAngles = transform.eulerAngles;

        jumping = false; 

    }

    private void Update()
    {
        // ren = GetComponent<Renderer>();
        var isStable = gameObject.GetComponent<IsStable>();
        var isSquish = gameObject.GetComponent<Squish>();


        // if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) 
        // {
        //     jumping = false;
        //     isKeyDown = true;
        // }

        if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))  && isStable.Get() == true)
        {
            scoreUI.enabled = false;
            levelUI.enabled = false;
            isSquish.Set(true);
            jumpAmount += 7f * Time.deltaTime;
            transform.eulerAngles = currentEulerAngles;
        }
        if ((Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0)) && isStable.Get() == true)
        {
            // jumping = true;
            // isKeyDown = false;
            Vector3 dir = new Vector3(0, 8.8f, 4.2f);
            isStable.Set(false);
            rb.velocity = jumpAmount*dir;
            jumpAmount = 7f;
            isSquish.Set(false); 
        }

    }

    void FixedUpdate()
    {
        Vector3 gravity = -300.0f * 1.0f * Vector3.up;
        rb.AddForce(gravity, ForceMode.Acceleration);
    }
}

