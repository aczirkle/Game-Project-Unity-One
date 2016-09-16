using UnityEngine;
using System.Collections;

public class RigidBodyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody rg = GetComponent<Rigidbody>();
        rg.useGravity = false; 
        if (rg != null)
        {
            rg.velocity = new Vector3(-6.0f, 0.0f, 0.0f);
        } 
	}
}
