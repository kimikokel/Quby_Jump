using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpVelocity : MonoBehaviour
{
    public Rigidbody rb;
    // public float buttonTime;
    public float jumpAmount;

    // public float Forward;

    // float jumpTime;

    bool jumping;

    // bool stable;

    Renderer ren;

    private void Update()
    {
        // ren = GetComponent<Renderer>();
        var isStable = gameObject.GetComponent<IsStable>();
        var isSquish = gameObject.GetComponent<Squish>();

        if (Input.GetKey(KeyCode.Space) && isStable.Get() == true)
        {
            isSquish.Set(true);
            jumpAmount += 1.5f * Time.deltaTime;
            // ren.material.color = Color.red;
        }
        if (Input.GetKeyUp(KeyCode.Space) && isStable.Get() == true)
        {
            // print("jumping");
            Vector3 dir = new Vector3(0, 5, 2.5f);
            isStable.Set(false);
            rb.velocity = jumpAmount*dir;
            jumpAmount = 8;
            isSquish.Set(false);
        }

    }

    void FixedUpdate()
    {
        Vector3 gravity = -50.0f * 1.0f * Vector3.up;
        rb.AddForce(gravity, ForceMode.Acceleration);
    }
}

