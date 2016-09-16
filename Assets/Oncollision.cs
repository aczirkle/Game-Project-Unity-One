using UnityEngine;
using System.Collections;

public class Oncollision : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
    {
        print("Collision Enter " + collision.gameObject.name);
    }
    void OnCollisionStay(Collision collision)
    {

    }
    void OnCollisionExit(Collision collision)
    {

    }
}
