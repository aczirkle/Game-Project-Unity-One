using UnityEngine;
using System.Collections;

public class changeHeading : MonoBehaviour {

    float rot = 10.0f;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("right"))
        gameObject.transform.Rotate(new Vector3(0,rot,0));
        if(Input.GetKey("left"))
        gameObject.transform.Rotate(new Vector3(0,-rot,0));
	}
}
