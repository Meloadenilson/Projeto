using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaPersonagem : MonoBehaviour {
	float vida;
	public Text vidaTexto;

	// Use this for initialization
	void Start () {
		vida = 100;
	}
	
	// Update is called once per frame
	void Update () {
		vidaTexto.text = vida.ToString("Vida 0");

		if (vida == 0){
			SceneManager.LoadScene ("gameOver");
		}
	}


	void OnCollisionEnter2D(Collision2D colisao){
			if (colisao.gameObject.tag == "dano") 
			{
				vida -= 10; 
			}
			
		}

}
