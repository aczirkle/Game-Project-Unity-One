using UnityEngine;
using System.Collections;

public class ObjectMaker : MonoBehaviour {

	public GameObject ObjectToSpawn;
	public int totalToSpawn = 40;
	// Use this for initialization
	void Start () {
	
		for (int i=0; i<totalToSpawn; i++)
		{
			Quaternion rot = new Quaternion(0, Random.value *360 -180, 0, 180);
			//GameObject clone = Instantiate(ObjectToSpawn, new Vector3(Random.Range(-25, 25), 1, Random.Range(-25, 25)), rot) as GameObject;
			Instantiate(ObjectToSpawn, new Vector3(Random.Range(-25, 25), 1, Random.Range(-25, 25)), rot);
			//clone.GetComponent<Rigidbody>().useGravity = true;//.useGravity(true);

		}
	}


}
