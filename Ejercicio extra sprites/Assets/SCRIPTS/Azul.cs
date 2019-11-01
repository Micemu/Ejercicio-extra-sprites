using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.C)){

			Debug.Log ("He movido el sprite azul hacia arriba");

			transform.Translate (Vector2.up * Time.deltaTime);
		}


		if(Input.GetKeyDown(KeyCode.D)){

			Debug.Log ("He movido el sprite azul hacia abajo");

			transform.Translate (Vector2.down * Time.deltaTime);
		}


	}
}
