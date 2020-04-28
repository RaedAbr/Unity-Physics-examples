using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    //TriggerEnter
    void OnTriggerEnter(Collider other)
    {
		Debug.Log ("Collision on");
        
    }
	
	//Trigger ongoing
    void OnTriggerStay(Collider other)
    {
		Debug.Log ("Collision ongoing");
        
    }
	
	//Trigger Finish
    void OnTriggerExit(Collider other)
    {
		Debug.Log ("Collision finished");
        
    }

    
}
