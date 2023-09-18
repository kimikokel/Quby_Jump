using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision target) { 
        if (target.gameObject.tag == "Player")  {  
             SceneManager.LoadScene("MainScene");  
        }  
    }  

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown("q")) {
        SceneManager.LoadScene("MainScene");  
    }
    }
}
