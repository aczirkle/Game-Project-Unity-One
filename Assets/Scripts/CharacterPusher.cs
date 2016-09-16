using UnityEngine;
using System.Collections;

public class CharacterPusher : MonoBehaviour {

	public float pushPower = 2.0f;
	void OnControllerColliderHit(ControllerColliderHit hit) {
		//hit.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(gameObject.transform.forward, gameObject.transform.position);
		//hit.gameObject.GetComponent<
	//	print ("AAttepting to apply force");
		Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic) {
        //    print("body is null");
			return;
    }
        //if (hit.moveDirection.y < .3f)
        //{
         //   print("move direction<.3f");
         //   return;
        //}
      //  print("Applying force");
		body.velocity = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z) *pushPower;
	}
}
