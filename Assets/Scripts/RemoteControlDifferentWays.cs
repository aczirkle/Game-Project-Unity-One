using UnityEngine;
using System.Collections;

public class RemoteControlDifferentWays : MonoBehaviour {


    GameObject d1;
    GameObject d2;
    public GameObject d3; 
	// Use this for initialization
    void Start()
    {
        d1 = GameObject.Find("Dropper1");
        if (d1 != null)
        {
            print("Object with \"Dropper1\" name found.");
        }
        else
        {
            print("Object with \"Dropper1\" name was NOT found.");
        }
        d2 = GameObject.FindGameObjectWithTag("DropGroup");
        if (d2 != null)
        {
            print("Object with \"Dropper2\" name found.");
        }
        else
        {
            print("Object with \"Dropper2\" name was NOT found.");
        }
    }
    void OnMouseDown(){
        Rigidbody rigBod1 = d1.GetComponent<Rigidbody>();
        rigBod1.useGravity = true;

        Rigidbody rigBod2 = d2.GetComponent<Rigidbody>();
        rigBod2.useGravity = true;

        Rigidbody rigBod3 = d3.GetComponent<Rigidbody>();
        rigBod3.useGravity = true;

        GameObject d4 = GameObject.Find("Dropper4");
        DropScript d4Script = d4.GetComponent<DropScript>();
        d4Script.Drop();

        GameObject d45 = GameObject.Find("DropGroup");

        if (d45 != null)
        {
            print("Object with \"Dropper5\" name found.");
            d45.BroadcastMessage("DropMessage", 10.0f);
        }
        else
        {
            print("Object with \"Dropper5\" name was NOT found.");
        }
        

    }
}
