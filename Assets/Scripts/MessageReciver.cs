using UnityEngine;
using System.Collections;

public class MessageReciver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void DropMessage(float value = 5.0f)
    {
        Rigidbody rigBod = GetComponent<Rigidbody>();
        rigBod.useGravity = true;
        print(gameObject.name + " dropped with a " + value + ".");
    } 
}
