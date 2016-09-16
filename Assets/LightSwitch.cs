using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
//        Vector3 moveVector = Vector3.zero;
        if (Input.GetKeyDown("f"))
        {
			print("Flashlight");
            gameObject.GetComponent<Light>().enabled = !(gameObject.GetComponent<Light>().enabled);

        }
	}
}
