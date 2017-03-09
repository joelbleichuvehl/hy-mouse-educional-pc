using UnityEngine;
using System.Collections;

public class ColisaoScript : MonoBehaviour {

	//public RectTransform panelReload;

	//public GameObject sangue;

	public bool teste;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		testar ();
	}

	void OnTriggerEnter2D(Collider2D colisao){
		if(colisao.gameObject.tag.Equals("Player")){
			teste = true;
			//Destroy(colisao.gameObject);
			//Instantiate(sangue, colisao.gameObject.transform.position, colisao.gameObject.transform.rotation);
			//panelReload.localScale = new Vector3(1 , 1, 1);
		}

		if(colisao.gameObject.tag.Equals("ProximoLevel")){
			Application.LoadLevel("Level_02");
		}
	}

	public bool testar(){
		return teste;
	}
}
