using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class health : MonoBehaviour {
	bool dead=false;
	//public float hp=100;
	public Slider hp;
	public int score;
	public int toWin;
	//public Text lose;
	public GameObject lose;
	public GameObject win;
	void Start(){
		hp.value=100;
		score=0;
		toWin=5;
		//GameObject
		lose = GameObject.FindGameObjectWithTag("Finish");
		win = GameObject.FindGameObjectWithTag("EditorOnly");
		win.SetActive(false);
		lose.SetActive(false);
	}
	public void lowerHP(){
		hp.value=-10;
	}
	void Update(){
		if(hp.value<=0 && !dead){
			dead=true;
			gameObject.BroadcastMessage("youDied");
			//lose.enabled=true;
			lose.SetActive(true);
		}
		if(!dead &&score==toWin){
			win.SetActive(true);
			GameObject[] gos = (GameObject[])GameObject.FindGameObjectsWithTag("Enemy");
			foreach(GameObject go in gos){
				if(go && go.transform.parent==null)
					go.BroadcastMessage("stopFollow",null,SendMessageOptions.DontRequireReceiver);
			}
			dead=true;
			score++;
		}
			
	}
	void killedZomb(){
		score++;
	}
}
