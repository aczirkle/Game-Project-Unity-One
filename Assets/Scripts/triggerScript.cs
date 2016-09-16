using UnityEngine;
using System.Collections;

public class triggerScript : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + Random.Range(10, 20), gameObject.transform.position.z);
        rb.velocity = new Vector3(0, 0, 0);
        
    }
    void FixedUpdate()
    {
        if (gameObject.transform.position.y < 0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + Random.Range(10, 20), gameObject.transform.position.z);
        }

    }
}
