using UnityEngine;
using System.Collections;

public class DropScript : MonoBehaviour {

    public void Drop()
    {
        Rigidbody rigBod1 = this.GetComponent<Rigidbody>();
        rigBod1.useGravity = true;

    }
}
