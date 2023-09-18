using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpVelocity : MonoBehaviour
{
    public Rigidbody rb;
    // public float buttonTime;
    public float jumpAmount;

    public float Forward;

    // float jumpTime;

    bool jumping;

    bool stable;

    Renderer ren;

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "platform")
        {
            stable = true;

            print("stable true");
        }
    }

    private void Update()
    {

        // if (Input.GetKeyDown(KeyCode.Space) && stable == true)
        // {
        //     jumping = true;
        // }
        // if (jumping)
        // {
        //     stable = false;
        //     rb.velocity = new Vector3(rb.velocity.x, jumpAmount * 2, jumpAmount);
        // }
        // if (Input.GetKeyUp(KeyCode.Space))
        // {
        //     jumping = false;
        // }
        ren = GetComponent<Renderer>();

        if (Input.GetKey(KeyCode.Space) && stable == true)
        {
            jumpAmount += 0.03f;
            ren.material.color = Color.red;
        }
        if (jumping)
        {
            Vector3 dir = new Vector3(0, 2.5f, 1);
            stable = false;
            rb.velocity = jumpAmount*dir;
            jumping = false;
            jumpAmount = 0;
            ren.material.color = Color.black;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jumping = true;
        }
    }
}
