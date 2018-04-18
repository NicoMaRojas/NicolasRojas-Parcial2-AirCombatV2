using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		//mover avion arriba
		if (Input.GetKey (KeyCode.Space)) {
			this.transform.Translate (0.0f, 0.0f, 1.8f);
		}

			if (Input.GetKey (KeyCode.UpArrow)) {
				this.transform.Translate (0.0f, 0.7f, 0.0f);
		}
	
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -0.7f, 0.0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (0.7f, 0.0f, 0.0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (-0.7f, 0.0f, 0.0f);
		}


		// Si la tecla espacio fue presionada
		if (Input.GetKeyDown (KeyCode.Z)) {

			//Reconstruyo un gameObject a partir
			// de la informacion guardad en un prefab
			GameObject missile = GameObject.Instantiate (Resources.Load ("Prefabs/Misil2EMP") as GameObject);

			//misil hijo de avion
			missile.transform.SetParent(this.gameObject.transform);
			//cordenadas relativas al avion
			missile.transform.localPosition = new Vector3 (-2.324f,-5.644f,7.23f);
			//misil independiente al avion
			missile.transform.SetParent(null);
		}

		// Si la tecla espacio fue presionada
		if (Input.GetKeyDown (KeyCode.X)) {

			//Reconstruyo un gameObject a partir
			// de la informacion guardad en un prefab
			GameObject missile = GameObject.Instantiate (Resources.Load ("Prefabs/Misil1EMP") as GameObject);

			//misil hijo de avion
			missile.transform.SetParent(this.gameObject.transform);
			//cordenadas relativas al avion
			missile.transform.localPosition = new Vector3 (2.324f,-5.644f,7.23f);
			//misil independiente al avion
			missile.transform.SetParent(null);
		}

	}
}
