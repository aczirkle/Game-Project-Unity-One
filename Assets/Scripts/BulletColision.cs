using UnityEngine;
using System.Collections;

public class BulletColision : MonoBehaviour {

    public GameObject explosionPrefab;
//    CharacterController controller;
    public float FowardSpeed = 5.0f;
    public float maxRotationSpeed = 5.0f;
    //Vector3 directionVector;
	// Use this for initialization
	void Start () {
//        controller = GetComponent<CharacterController>();
//        directionVector = transform.forward;
	}
	
	// Update is called once per frame
    void Update()
    {
        //controller.Move(directionVector * FowardSpeed * Time.deltaTime);
        //transform.forward = Vector3.Slerp(transform.forward, directionVector, Time.deltaTime * maxRotationSpeed);
    }

   /* void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("enemy")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }*/
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("enemy")){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject explosion = Instantiate(explosionPrefab, pos, rot) as GameObject;
        Destroy(explosion, 3.0f);
        }
    }



}
