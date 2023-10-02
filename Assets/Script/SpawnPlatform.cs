using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public Vector3 minPosition;
    public Vector3 maxPosition;

    public GameObject prevPlat;

    bool isTouched = false;

    public static Vector3 prevPosition = Vector3.zero;

    void Start()
    {
        // prevPosition = Vector3.zero;
    }

    // Squish isSquish = gameObject.GetComponent<Squish>();

    void OnCollisionEnter(Collision collision)
    {

        // if (collision.gameObject.tag == "Player" && gameObject.GetComponent<Squish>().Get() == false)
        // {
        //     Vector3 randomPosition = new Vector3(
        //     0,
        //     Random.Range(minPosition.y, maxPosition.y),
        //     Random.Range(minPosition.z, maxPosition.z)
        //     );
        //     prevPlat = Instantiate(objectToSpawn, randomPosition + prevPlat.transform, Quaternion.identity);
        // }
        // if (collision.gameObject.tag == "Player" && collision.gameObject.GetComponent<Squish>().Get() == false)
        if (collision.gameObject.tag == "Player" && isTouched == false)
        {
            float ranY = Random.Range(8.5f, -15f);
            float ranZ = Random.Range(-40f, -23f);
            // float ranY = 0;
            // float ranZ = -34;

            float oriY = prevPosition.y;
            float oriZ = prevPosition.z;
            float newY = oriY - ranY;
            float newZ = oriZ - ranZ;

            isTouched = true;

            Vector3 randomPosition = new Vector3(
             prevPosition.x,
             newY,
             newZ
            );

            print("prev:" + prevPosition);
            print("random:" + randomPosition);

            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
            prevPosition = randomPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if (gameObject.GetComponent<Squish>().Get() == false) {
        //     print("false");
        // }
    }
}
