using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public GameObject bullet;
    public float speed = 10;

	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Fire1")){
            GameObject clone;
            clone = Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * speed);
            Destroy(clone, 10f);
        }
	}
}
