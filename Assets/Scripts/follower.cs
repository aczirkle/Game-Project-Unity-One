using UnityEngine;
using System.Collections;

public class follower : MonoBehaviour {

	public Transform target;
	public GameObject bullet;
	int fireRate =3;
	void Start(){
		StartCoroutine(fire());
	}
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
	}
	IEnumerator fire(){
		for (; true; )
		{
		print("Bang!");
		Vector3 endOfGun = transform.TransformDirection(new Vector3(0.0f, 0.0f, 4.0f));
		GameObject instance = Instantiate( bullet, transform.position + endOfGun, transform.rotation) as GameObject;
			instance.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward);
			//instance.AddForce( transform.TransformDirection(Vector3.forward));
		//instance.velocity = transform.TransformDirection(Vector3.forward);
		Destroy(instance, 10f);
		yield return new WaitForSeconds(fireRate);
		}
	}
}
