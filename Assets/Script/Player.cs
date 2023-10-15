using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    DeadUI deadUI;
    // Start is called before the first frame update
    void Start()
    {
        deadUI = GameObject.Find("DeadUI").GetComponent<DeadUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -13) {
            SpawnPlatform.prevPosition = Vector3.zero;
            deadUI.Show();
        }

        if (Input.GetKeyDown("q")) {
            SpawnPlatform.prevPosition = Vector3.zero;
            SceneManager.LoadScene("MainScene");  
        }       
    }
}
