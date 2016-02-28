using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour {

	public GameObject block;

	private Vector2 spawn;

	// Use this for initialization
	void Start () {

		float posY =  Random.Range (0f, 15f);
		float posX = Random.Range(15, 30f);

		Vector2 spawn = new Vector2 (posX, posY);

		GenerateBlocks ();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GenerateBlocks(){

		Instantiate (block, spawn, Quaternion.identity);


	}
}
