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
            Vector3 squishy = transform.localScale;
            if (squishy.y > 1.1f)
            {
                transform.localScale = new Vector3(squishy.x, squishy.y-1.88f*Time.deltaTime, squishy.z);
                // transform.localScale = new Vector3(squishy.x, squishy.y*0.88f, squishy.z);
            }
        }
        if (!squish)
        {
            transform.localScale = new Vector3(trans.x, trans.y, trans.z);
        }
        
    }
}
