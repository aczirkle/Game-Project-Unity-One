using UnityEngine;
using System.Collections;

public class collissionDie : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		//print("Collision Enter " + other.gameObject.name);
		if(other.gameObject.name == "myFirstPersonController"){
			other.gameObject.transform.position=GameObject.FindGameObjectWithTag("Respawn").transform.position;
			other.gameObject.GetComponent<health>().hp.value=other.gameObject.GetComponent<health>().hp.value-25;//.lowerHP();
			//gameObject.SendMessageUpwards("stopFollow");
			GameObject[] gos = (GameObject[])GameObject.FindGameObjectsWithTag("Enemy");
			foreach(GameObject go in gos){
				if(go && go.transform.parent==null)
					go.BroadcastMessage("stopFollow",null,SendMessageOptions.DontRequireReceiver);
			}
			//gameObject.GetComponentInParent<gameObject>().BroadcastMessage("stopFollow");
			//gameObject.BroadcastMessage("stopFollow");
			//GameObject g=GameObject.Find("Lives").GetComponent<Slider>();

		}
			


	}

}
