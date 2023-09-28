using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public Vector3 minPosition;
    public Vector3 maxPosition;

    Vector3 original;

    public GameObject prevPlat;

    void Start()
    {
        original = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // var isSquish = gameObject.GetComponent<Squish>();

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
        if (collision.gameObject.tag == "Player")
        {
            float ranY = Random.Range(8.5f, -15f);
            float ranZ = Random.Range(-40f, -23f);
            float oriY = prevPlat.transform.position.y;
            float oriZ = prevPlat.transform.position.z;
            float newY = oriY - ranY;
            float newZ = oriZ - ranZ;

            Vector3 randomPosition = new Vector3(
             prevPlat.transform.position.x,
             newY,
             newZ
            ); //problem now is spawn too much platform

            // print("ori y: " + oriY + "\nranY: " + ranY + "\nadded : " + newY);
            // print("ori z: " + oriZ + "\nranZ: " + ranZ + "\nadded : " + newZ);

            prevPlat = Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
