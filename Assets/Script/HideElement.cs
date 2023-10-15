using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideElement : MonoBehaviour
{
    // Start is called before the first frame update
	public float time = 5;

	IEnumerator Start ()
	{
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
