using UnityEngine;
using System.Collections;

public class MoveTrain : MonoBehaviour {

	void Start(){
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("TrainPath"), "time", 25, "easytype", iTween.EaseType.easeOutSine));
	}
}
