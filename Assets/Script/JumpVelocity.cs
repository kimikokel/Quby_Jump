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

    // bool jumping;

    // bool stable;

    Renderer ren;

    // void OnCollisionEnter(Collision target)
    // {
    //     if (target.gameObject.tag == "platform")
    //     {
    //         stable = true;

    //         print("stable true");
    //     }
    // }



    private void Update()
    {
        // ren = GetComponent<Renderer>();
        var isStable = gameObject.GetComponent<IsStable>();
        var isSquish = gameObject.GetComponent<Squish>();

        if (Input.GetKey(KeyCode.Space) && isStable.Get() == true)
        {
            print("fuckoff");
            isSquish.Set(true);
            jumpAmount += 0.03f;
            // ren.material.color = Color.red;
        }
        if (Input.GetKeyUp(KeyCode.Space) && isStable.Get() == true)
        {
            print("jumping");
            Vector3 dir = new Vector3(0, 2.5f, 1);
            isStable.Set(false);
            rb.velocity = jumpAmount*dir;
            jumpAmount = 0;
            isSquish.Set(false);
        }
    }
}
