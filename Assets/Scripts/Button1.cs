using UnityEngine;
using System.Collections;

public class Button1 : MonoBehaviour {

	void Update() {
		//Debug.Log ("Update");
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			//Debug.Log ("A huevo");
		}
	}


    void OnMouseDown()
    {
        Debug.Log("Click On me");
    }
}
