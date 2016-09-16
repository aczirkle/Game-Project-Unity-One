using UnityEngine;
using System.Collections;

public class rotateUpAndDown : MonoBehaviour {

    float rot = 20.0f;
    int min = -45;
    int max =  45;
    Vector3 v3Rotate = Vector3.zero;

    void Start()
    {
        transform.localEulerAngles = v3Rotate;
    }
	// Update is called once per frame
	void Update () {
        
       // if ()
        if (Input.GetKey("up"))
        {
            v3Rotate.x -= rot * Time.deltaTime;
            v3Rotate.x = Mathf.Clamp(v3Rotate.x, min, max);
            transform.localEulerAngles = v3Rotate;
        }
        if (Input.GetKey("down"))
        {
            v3Rotate.x += rot * Time.deltaTime;
            v3Rotate.x = Mathf.Clamp(v3Rotate.x, min, max);
            transform.localEulerAngles = v3Rotate;
        }
            //transform.localEulerAngles = Input.GetKey("up") * rot * Time.deltaTime;
      //  if (Input.GetKey("down"))
          //  gameObject
    }


    float GetPlusMinusAngle(float angle)
    {
        if (angle > 45)
        {
            return angle - 360;
        }
        else
        {
            return angle;
        }
    }
}
