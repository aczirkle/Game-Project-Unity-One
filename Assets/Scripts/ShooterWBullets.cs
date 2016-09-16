using UnityEngine;
using System.Collections;

public class ShooterWBullets : MonoBehaviour {

	public GameObject bullet;
	public float speed = 10;
	public float mag = 30;

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && mag>0){
			mag--;
			GameObject clone;
			clone = Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * speed);
			Destroy(clone, 10f);
		}
	}
	public void reload(){
		mag=30;
	}
}
