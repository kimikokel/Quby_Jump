using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsStable : MonoBehaviour
{
    private bool stable = true;

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "platform")
        {
            stable = true;

            // print("stable true");

        }
    }

    public bool Get()
    {
        return stable;
    }

    public void Set(bool stable_)
    {
        stable = stable_;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // print(stable);
    }
}
