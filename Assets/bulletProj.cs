using UnityEngine;
using System.Collections;

public class bulletProj : MonoBehaviour {

	public GameObject explosionPrefab;
//	CharacterController controller;
	public float FowardSpeed = 5.0f;
	public float maxRotationSpeed = 5.0f;
//	Vector3 directionVector;
	// Use this for initialization
	void Start () {
//		controller = GetComponent<CharacterController>();
//		directionVector = transform.forward;
	}

	void OnCollisionEnter(Collision collision)
	{
//		print("Hit something");
		if(collision.gameObject.tag.Equals("Enemy")){
			//Destroy(collision.gameObject);
			collision.gameObject.GetComponent<ZombFoll>().die();
			Destroy(gameObject);

			ContactPoint contact = collision.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			GameObject explosion = Instantiate(explosionPrefab, pos, rot) as GameObject;
			Destroy(explosion, 3.0f);
		}
	}
}
