using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    float y;

    // Start is called before the first frame update
    void Start()
    {
        y = transform.position.y;
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        var pst = target.position + offset;
        pst.y = y;
        transform.position = pst;
    }
}
