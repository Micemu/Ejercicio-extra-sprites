using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verde : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E)) {
			Debug.Log ("He movido el sprite verde hacia la izquierda");

			transform.Translate (Vector2.left * Time.deltaTime);

		}

		if (Input.GetKey (KeyCode.F)) {
			Debug.Log ("He movido el sprite verde hacia la derecha");

			transform.Translate (Vector2.right * Time.deltaTime);

		}


		if(Input.GetKeyDown(KeyCode.G)){

			Debug.Log ("He movido el sprite azul hacia arriba");

			transform.Translate (Vector2.up * Time.deltaTime);
		}


		if(Input.GetKeyDown(KeyCode.H)){

			Debug.Log ("He movido el sprite azul hacia abajo");

			transform.Translate (Vector2.down * Time.deltaTime);
		}
	}
}
