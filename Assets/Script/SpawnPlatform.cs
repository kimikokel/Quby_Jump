using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public Vector3 minPosition;
    public Vector3 maxPosition;

    void Start()
    {
        //     Vector3 randomPosition = new Vector3(
        //     0,
        //     Random.Range(minPosition.y, maxPosition.y),
        //     Random.Range(minPosition.z, maxPosition.z)
        // );
        // Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 original = transform.position;

        if (collision.gameObject.tag == "Player")
        {
            Vector3 randomPosition = new Vector3(
            0,
            Random.Range(original.y+minPosition.y, original.y+maxPosition.y),
            Random.Range(original.z+minPosition.z, original.z+maxPosition.z)
            );
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
