using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {

			Debug.Log ("He movido el sprite rojo hacia la izquierda");

			transform.Translate (Vector2.left * Time.deltaTime);

		}

		if (Input.GetKeyDown (KeyCode.B)) {

			Debug.Log ("He movido el sprite rojo hacia la derecha");

			transform.Translate (Vector2.right * Time.deltaTime);

		}

		}
	}

