using System;
using UnityEngine;

public class MoveTrain : MonoBehaviour {
    
    private void Start() {
		moveToPath("TrainPath1");
    }

    private void Update() {
        if (gameObject.GetComponent<Renderer>().enabled == false) {
            gameObject.GetComponent<Renderer>().enabled = true;
        }

	}

	private void moveToPath(String path) {
		try {
			gameObject.GetComponent<Renderer>().enabled = false;
			iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath(path), "time", 10));
		} catch (Exception e) {
			Debug.Log(e.Message);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Button1") {
			if (other.gameObject.GetComponent<SpriteRenderer> ().sprite.name == "arrow-left") {
				moveToPath("TrainPath3");
			} else {
				moveToPath("TrainPath2");
			}
		}
    }
}
