using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPlatform : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 minPosition;
    public Vector3 maxPosition;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPosition = new Vector3(
            0,
            Random.Range(minPosition.y, maxPosition.y),
            Random.Range(minPosition.z, maxPosition.z)
        );
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
