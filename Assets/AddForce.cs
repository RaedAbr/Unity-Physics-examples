﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody rb;
 
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * 10);
    }
}
