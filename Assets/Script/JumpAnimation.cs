using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour
{
    public GameObject mainSlime;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(myWaitCoroutine());
        // LookAtCamera(); 
        // ChangeStateTo(SlimeAnimationState.Jump);
    }

    public void ChangeStateTo(SlimeAnimationState state)
    {
       if (mainSlime == null) return;    
       if (state == mainSlime.GetComponent<EnemyAi>().currentState) return;

       mainSlime.GetComponent<EnemyAi>().currentState = state ;
    }
    void LookAtCamera()
    {
       mainSlime.transform.rotation = Quaternion.Euler(new Vector3(mainSlime.transform.rotation.x, cam.transform.rotation.y, mainSlime.transform.rotation.z));   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator myWaitCoroutine()
    {
        while (true) {
            LookAtCamera(); 
            ChangeStateTo(SlimeAnimationState.Jump);
            yield return new WaitForSeconds(5f);
        }

    }
}
