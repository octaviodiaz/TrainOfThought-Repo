using UnityEngine;
using System.Collections;

public class MoveTrain : MonoBehaviour {

	void Start(){
		Debug.Log(iTweenPath.GetPath("TrainPath"));
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("TrainPath"), "time", 10));
	}
}
