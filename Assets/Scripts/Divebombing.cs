using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]
public class Divebombing : MonoBehaviour {

    public GameObject explosionPrefab;
    CharacterController controller;
    public float FowardSpeed = 5.0f;
    public float maxRotationSpeed = 5.0f;
//    Vector3 directionVector;
	bool following=false;
    GameObject r;
    // Use this for initialization
    void Start()
    {
        r = GameObject.FindGameObjectWithTag("Player");
        controller = GetComponent<CharacterController>();
//        directionVector = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
		if(!following){
    controller.Move(transform.forward * FowardSpeed * Time.deltaTime);
        transform.LookAt(r.transform.position);
       // transform.forward = Vector3.Slerp(transform.forward, r.transform.position, Time.deltaTime * maxRotationSpeed);
		}
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject explosion = Instantiate(explosionPrefab, pos, rot) as GameObject;
        Destroy(explosion, 3.0f);
    }
}

