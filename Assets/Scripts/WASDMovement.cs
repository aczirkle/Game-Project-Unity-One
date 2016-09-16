using UnityEngine;
using System.Collections;

public class WASDMovement : MonoBehaviour {

	float speed = 5.0f;
	// Update is called once per frame
	void Update () {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey("w"))
            direction += Vector3.forward* speed;
            //transform.Translate(Vector3.forward * speed * Time.deltaTime,Space.Self);
           // transform.position += (new Vector3(0.0f, 0.0f, ( speed)) * Time.deltaTime);
        if (Input.GetKey("s"))
            direction += Vector3.back * (float)(speed * .3);//  * Time.deltaTime, Space.Self);
            //transform.position += (new Vector3(0.0f, 0.0f, -(float)(speed * .3)) * Time.deltaTime);
        if (Input.GetKey("a"))
            direction += Vector3.left * (float)(speed * .6);
            //transform.Translate(Vector3.left * (float)(speed *.6) * Time.deltaTime, Space.Self);
            //transform.position += (new Vector3(-(float)(speed * .6), 0.0f, 0.0f) * Time.deltaTime);
        if (Input.GetKey("d"))
            direction += Vector3.right * (float)(speed * .6);
            //transform.Translate(Vector3.right * (float)( speed * .6 )* Time.deltaTime, Space.Self);
            //transform.position += (new Vector3((float)(speed * .6), 0.0f, 0.0f) * Time.deltaTime);
        
        transform.Translate(direction * Time.deltaTime, Space.Self);
         
	}
}
