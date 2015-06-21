using UnityEngine;
using System.Collections;

public class Button2 : MonoBehaviour {

	public Sprite rightArrow;
	public Sprite downArrow;

    void OnMouseDown() {
		if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == rightArrow) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = downArrow;
		} else {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = rightArrow;
		}
    }
}
