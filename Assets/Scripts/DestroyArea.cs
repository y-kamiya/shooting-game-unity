using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArea : MonoBehaviour {

	void OnTriggerExit2D(Collider2D collider) {
		Destroy (collider.gameObject);

		string layerName = LayerMask.LayerToName (collider.gameObject.layer);
		if (layerName == "Player") {
			FindObjectOfType<Manager> ().GameOver ();
		}
	}
}
