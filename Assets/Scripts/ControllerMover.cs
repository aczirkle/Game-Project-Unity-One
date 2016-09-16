using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]
public class ControllerMover: MonoBehaviour {
    
    CharacterController controller;
    public float FowardSpeed = 5.0f;
    public float maxRotationSpeed = 5.0f;
    Vector3 directionVector;
	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
        directionVector = transform.forward;
	}
	
	// Update is called once per frame
	void Update () {
        controller.Move(directionVector * FowardSpeed * Time.deltaTime);
        transform.forward = Vector3.Slerp(transform.forward,directionVector, Time.deltaTime * maxRotationSpeed);
	}
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        directionVector = Vector3.Reflect(directionVector, hit.normal);
        directionVector.y = 0;
        directionVector.Normalize();
    }
}
