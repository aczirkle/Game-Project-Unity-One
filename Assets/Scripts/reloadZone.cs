using UnityEngine;
using System.Collections;

public class reloadZone : MonoBehaviour {
	GameObject gun;
	// Use this for initialization
	void Start() {
		gun = GameObject.Find("bulletSpawn");
//		print(gun.name);
	}
	void OnTriggerEnter(Collider other)
	{
		ShooterWBullets b= gun.GetComponent<ShooterWBullets>();
		b.reload();
	//	print("reloaded");
		//Rigidbody rb = GetComponent<Rigidbody>();
		//gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + Random.Range(10, 20), gameObject.transform.position.z);
		//rb.velocity = new Vector3(0, 0, 0);

	}
	// Update is called once per frame
	void Update () {
		
	//	DropScript d4Script = d4.GetComponent<DropScript>();
	//	d4Script.Drop();
	}
}
