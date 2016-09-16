using UnityEngine;
using System.Collections;

public class landmine : MonoBehaviour {

    public GameObject explode;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Instantiate(explode);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("First")){
        Instantiate(explode, gameObject.transform.position,new Quaternion( 0,0,0,0));
        Destroy(gameObject);
    }
    }
}
