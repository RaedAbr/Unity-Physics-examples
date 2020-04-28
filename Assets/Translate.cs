using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
	void Start()
	{
		Debug.Log(transform.right);
	}
	// Update is called once per frame
	void Update()
    {
		transform.Translate(transform.right * 2 * Time.deltaTime);  
    }
}
