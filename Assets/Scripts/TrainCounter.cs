using UnityEngine;
using System.Collections;

public class TrainCounter : MonoBehaviour {

	public int totalTrains = 0;
	public int successfulTrains = 0;

	public static TrainCounter Instance {
		get;
		private set;
	}
	
	void Awake(){
		Instance = this;
	}
}