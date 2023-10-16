using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject deadUI;

    public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        dead = deadUI.GetComponent<DeadUI>().dead;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && dead)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    public void OnClickStart()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
