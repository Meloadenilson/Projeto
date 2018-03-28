﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magia : MonoBehaviour {
	public float tempoDeVida;
	private float tempoCorrent;

	public float velocidade;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
 		transform.Translate (velocidade * Time.deltaTime, 0, 0);

		tempoCorrent += Time.deltaTime;
		if (tempoCorrent >= tempoDeVida)
		{
			Destroy (gameObject);
		}
	}

	public void OnTriggerEnter2D()
	{
		Destroy (gameObject);
	}
}
