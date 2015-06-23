using System;
using UnityEngine;

public class MoveTrain : MonoBehaviour {
    
    private void Start() {
        try {
            gameObject.GetComponent<Renderer>().enabled = false;
            iTween.MoveTo(gameObject,
			              iTween.Hash("path", iTweenPath.GetPath("TrainPath"), "time", 10));

        } catch (Exception e) {
            Debug.Log(e.Message);
        }
    }

    private void Update() {
        if (gameObject.GetComponent<Renderer>().enabled == false) {
            gameObject.GetComponent<Renderer>().enabled = true;
        }

    }
	
	void OnTriggerEnter(Collider other) {
		Debug.Log("dother" + other.gameObject);
    }
}
