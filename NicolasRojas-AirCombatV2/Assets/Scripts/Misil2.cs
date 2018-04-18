using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		this.transform.Translate(0.0f,0.0f,5.0f);

	}

	void OnCollisionEnter (Collision collision) {


		if (collision.collider.gameObject.tag == "JupiterAlien") {

			//Carga prefab de una explosion

			GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefabs/Explosion2") as GameObject);
			// explosion donde este el misil
			explosion.transform.position = collision.collider.transform.position;

			//Elimnar enemigo

			Destroy (collision.collider.gameObject);

			//Destruimos el misil

			Destroy (this.gameObject);

		}




			if (collision.collider.gameObject.tag == "MarsAlien") {

				//Carga prefab de una explosion

				GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefabs/Explosion") as GameObject);
				// explosion donde este el misil
				explosion.transform.position = collision.collider.transform.position;

				//Elimnar enemigo

				Destroy (collision.collider.gameObject);

				//Destruimos el misil

				Destroy (this.gameObject);

			}

	}
}
