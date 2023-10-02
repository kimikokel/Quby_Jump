using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squish : MonoBehaviour
{
    bool squish = false;

    Vector3 trans;

    public bool Get()
    {
        return squish;
    }

    public void Set(bool squish_)
    {
        squish = squish_;
    }

    void Start()
    {
        trans = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        if (squish)
        {
            // print(trans);
            Vector3 squishy = transform.localScale;
            transform.localScale = new Vector3(squishy.x, squishy.y*0.99f, squishy.z);
        }
        if (!squish)
        {
            transform.localScale = new Vector3(trans.x, trans.y, trans.z);
        }
        
    }
}
