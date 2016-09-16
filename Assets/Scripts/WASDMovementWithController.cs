using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]
public class WASDMovementWithController : MonoBehaviour {

    CharacterController controller;
   // float speed = 5.0f;
    float fallSpeed = -2;
    float jumpSpeed = 3.0f;
	bool dead;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        Vector3 moveVector = Vector3.zero; 
        if (Input.GetKey("w")) {
             moveVector += transform.TransformDirection(Vector3.forward);
            
        }
        if (Input.GetKey("s"))
        {
            moveVector += transform.TransformDirection(Vector3.back);
            //controller.Move(moveVector * speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            moveVector += transform.TransformDirection(Vector3.left);
            //controller.Move(moveVector * speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            moveVector += transform.TransformDirection(Vector3.right);
            //controller.Move(moveVector * speed * Time.deltaTime);
        }
        
        //else
        //{
        //    fallSpeed = 0;
        //}
        if (!controller.isGrounded)
        {
            fallSpeed += Physics.gravity.y * Time.deltaTime;
        }
        else
        {
            fallSpeed = 0;
        }
		if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            fallSpeed = jumpSpeed;
        }
        moveVector.y = fallSpeed;
		if(!dead)
        	controller.Move(moveVector);
    }
	public void youDied(){
		dead=true;
	}
}
