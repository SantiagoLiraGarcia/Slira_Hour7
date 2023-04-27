using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumbers : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		int i;
		for (i = 22; i <= 100; i=i+2)
		{
			//if (i % 2 == 0);
			Debug.Log(i);
		}
	}


	// Update is called once per frame
	void Update()
    {
        
    }
}
