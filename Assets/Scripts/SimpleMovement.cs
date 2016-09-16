using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += (new Vector3(-6.0f, 0.0f, 0.0f) * Time.deltaTime); 
        //transform.Translate(new Vector3(-0.1f, 0f, 0f));
        //transform.position = transform.position + new Vector3(-0.1f, 0f, 0f); 
	}
}
