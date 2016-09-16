using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public GameObject ObjectToSpawn;
    public int totalToSpawn = 100;
    public float spawnInterval = .5f;
    public float y = 1;
	// Use this for initialization
	void Start () {
        y = gameObject.transform.position.y;
        StartCoroutine(spawn());
	}
    IEnumerator spawn()
    {
        
        for (int i=0; i<totalToSpawn; i++)
        {
            Quaternion rot = new Quaternion(0, Random.value *360 -180, 0, 180);
            //GameObject clone = Instantiate(ObjectToSpawn, new Vector3(Random.Range(-100, 100), y, Random.Range(-100, 100)), rot) as GameObject;
			Instantiate(ObjectToSpawn, new Vector3(Random.Range(-250, 250), y, Random.Range(-250, 250)), rot);
			yield return new WaitForSeconds(spawnInterval);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
