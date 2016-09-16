using UnityEngine;
using System.Collections;

public class OnControllerColliderHitScript : MonoBehaviour {

	void OnControllerColliderHit(ControllerColliderHit hit) {
		print ("CharacterController hit " + hit.gameObject.name);
	}
}
