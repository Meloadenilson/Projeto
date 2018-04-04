using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DescobrirPalavra : MonoBehaviour {
	//public static Text palavraDigitada;
	public InputField meuInput;
	public GameObject pedra;
	public float distancia;
	public GameObject destruir;
	// Use this for initialization
	void Start () {
		meuInput.DeactivateInputField();
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector2.Distance (transform.position, pedra.transform.position) < distancia) {
			meuInput.ActivateInputField ();
			Destroy (destruir);
		} else {
			meuInput.DeactivateInputField();
		}

		if (meuInput.text == "frio") {
			SceneManager.LoadScene ("parabens");
		}
	}
}
