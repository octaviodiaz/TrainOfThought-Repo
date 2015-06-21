using UnityEngine;
using System.Collections;

public class Button1 : MonoBehaviour {

	public Sprite leftArrow;
	public Sprite downArrow;

    void OnMouseDown() {
		if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == leftArrow) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = downArrow;
		} else {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = leftArrow;
		}
    }
}
