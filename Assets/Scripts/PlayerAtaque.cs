using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerAtaque: MonoBehaviour {
	public float tempoMaxCarregar;
	public float delayDoAtaque;

	public Transform posicaoDisparo;

	public GameObject magia;
	private float tempoDelay;
	private float tempoCarregar;

	private bool atire ;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetMouseButton (0) && atire == false)
		{
			
			tempoCarregar += Time.deltaTime;
			if (tempoCarregar >= tempoMaxCarregar)

				atire = true;
				tempoCarregar = 0;
			}
		}
		if (atire) 
		{
			Disparar ();
		}
		
	}
	public void Disparar()
	{
		tempoDelay += Time.deltaTime;
		if (tempoDelay >= delayDoAtaque) 
		{
			Instantiate (magia, posicaoDisparo.position, posicaoDisparo.rotation);
			tempoDelay = 0;
			atire = false;
			print ("atirou");  
		}

	}
}
