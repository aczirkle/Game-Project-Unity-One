using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]
public class ZombFoll: MonoBehaviour {

	CharacterController controller;
	public float FowardSpeed = 5.0f;
	public float maxRotationSpeed = 5.0f;
//	Vector3 directionVector;
	public bool following=false;
	GameObject r;
    public int hp = 1;
    float fallSpeed = -2;
	// Use this for initialization
	void Start()
	{
		r = GameObject.FindGameObjectWithTag("Player");
		controller = GetComponent<CharacterController>();
	//	directionVector = transform.forward;
	}

	// Update is called once per frame
	void Update()
	{
		if(following){
			controller.Move(transform.forward * FowardSpeed * Time.deltaTime);
			transform.LookAt(r.transform.position);
			// transform.forward = Vector3.Slerp(transform.forward, r.transform.position, Time.deltaTime * maxRotationSpeed);
		}
        if (!controller.isGrounded)
        {
            fallSpeed += Physics.gravity.y * Time.deltaTime;
        }
        else
        {
            fallSpeed = 0;
        }
        Vector3 moveVector = Vector3.zero;
        moveVector.y = fallSpeed;
        controller.Move(moveVector);
	}
	void OnTriggerEnter(Collider other)
	{
//		print(other.name);
        if (other.gameObject.name.Equals("myFirstPersonController")) { 
		following=true;
//		print("Collided");
        if (FowardSpeed > 0)
        {
            Animator ani = GetComponent<Animator>();
            ani.SetBool("attacking", true);
        }
		}
		//Destroy(gameObject);
		//ContactPoint contact = collision.contacts[0];
		//Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		//Vector3 pos = contact.point;
		//GameObject explosion = Instantiate(explosionPrefab, pos, rot) as GameObject;
		//Destroy(explosion, 3.0f);
	}
	public void die(){
        hp--;
        if (hp == 0)
        {
            Animator ani = GetComponent<Animator>();
            ani.SetBool("dead", true);
            ani.SetBool("attacking", false);
            FowardSpeed = 0;
			GameObject.FindGameObjectWithTag("Player").SendMessage("killedZomb");
            Destroy(gameObject, 10);
        }
	}
    public void stopFollow()
    {
        following = false;
    }
}

