using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	Vector3 distance;
	float posX;
	float posY;
	// Use this for initialization
	void Update(){
	
	}
	void OnMouseDown () {
		distance = Camera.main.WorldToScreenPoint (transform.position);
		posX = Input.mousePosition.x - distance.x;
		posY = Input.mousePosition.y - distance.y;
	}
	
	// Update is called once per frame
	void OnMouseDrag () {
		Vector3 curPos = new Vector3 (Input.mousePosition.x  - posX, Input.mousePosition.y  - posY, distance.z);
		Vector3 worldPos = Camera.main.ScreenToWorldPoint (curPos);
		transform.position = worldPos;
	}
}
