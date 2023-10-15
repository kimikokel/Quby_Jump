using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public Vector3 minPosition;
    public Vector3 maxPosition;

    public GameObject prevPlat;

    int score;

    public bool isTouched = false;

    public static Vector3 prevPosition = Vector3.zero;

    AddPoints AP;
    IsStable isStable;
    public TMP_Text scoreUI;
    public TMP_Text levelUI;
    Animator scoreAni;
    Animator levelAni;
    AudioSource audio;

    List<int> scoreList = new List<int>() {10, 5, 3, 1, 0};
    List<string> nameList = new List<string>() {"Perfect", "Great", "Good", "OK", "Bye"};

    void Start()
    {
        AP = GameObject.Find("AddPoints").GetComponent<AddPoints>();
        isStable = GameObject.Find("IsStable").GetComponent<IsStable>();
        audio = GameObject.Find("LandingBGM").GetComponent<AudioSource>();
        scoreUI = GameObject.Find("scoreText").GetComponent<TMP_Text>();
        levelUI = GameObject.Find("nameText").GetComponent<TMP_Text>();
        scoreAni = GameObject.Find("scoreText").GetComponent<Animator>();
        levelAni = GameObject.Find("nameText").GetComponent<Animator>();
    }

    // Squish isSquish = gameObject.GetComponent<Squish>();


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player" && isTouched == false)
        {
            // float ranY = Random.Range(-8.5f, 15f);
            float ranZ = Random.Range(20f, 40f);
            float ranY = 0;
            float oriY = prevPosition.y;
            float oriZ = prevPosition.z;
            float newY = oriY + ranY;
            float newZ = oriZ + ranZ;

            isTouched = true;

            Vector3 randomPosition = new Vector3(
             prevPosition.x,
             newY,
             newZ
            );
            
            Vector3 blkXZ = new Vector3(prevPosition.x, 0, prevPosition.z);
            Vector3 plyPos = collision.gameObject.transform.position;
            Vector3 plyXZ = new Vector3(plyPos.x, 0, plyPos.z);

            float distance = Vector3.Distance(blkXZ, plyXZ);
            // print(distance);

            int scoreIndex = 0;

            if (0 < distance && distance < 1.5f) {
                scoreIndex = 0;
            }

            else if (1.5f < distance && distance < 3.0f) {
                scoreIndex = 1;
            }
            
            else if (3.0f < distance && distance < 4.5f) {
                scoreIndex = 2;
            }

            else if (4.5f < distance && distance < 6.0f) {
                scoreIndex = 3;
            }

            else
            {
                scoreIndex = 4;
            }

            print(scoreIndex);
            print(distance + " " + scoreList[scoreIndex]  + nameList[scoreIndex]);
            if (!scoreUI)
            {
                return;
            }
            // print(scoreUI == null);
            // print(scoreUI.text == null);

            scoreUI.enabled = true;
            levelUI.enabled = true;


            scoreUI.text = "+" + scoreList[scoreIndex].ToString();
            levelUI.text = nameList[scoreIndex].ToString();

            // scoreAni["scoreUI"].wrapMode = WrapMode.Once;
            scoreAni.Play("scoreUI", -1, 0f);
            levelAni.Play("levelUI", -1, 0f);

            audio.Play(0);

            score = AP.Get();
            AP.Set(score + scoreList[scoreIndex]);

            // print("prev:" + prevPosition);
            // print("random:" + randomPosition);

            GameObject newBlock = Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
            newBlock.transform.localScale *= Random.Range(0.8f, 1.2f);
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
