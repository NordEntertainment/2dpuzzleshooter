using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnTester : MonoBehaviour {

	public GameObject Block;

	public int maxBox = 8;	// max antall bokser
	public float maxX = 10f; //slutt bredde
	public float minX = 0f; //start bredde
	public float maxY = 10f; //slutt høyde
	public float minY = 0f; //start høyde


	private Vector2 originPosition;



	// Use this for initialization
	void Start () {

		Spawn ();
	}

	void Spawn()
	{
		for (int i = 0; i < maxBox; i++)
		{
			Vector2 randomPosition = new Vector2 (Random.Range(minX, maxX), Random.Range (minY, maxY));
			Instantiate (Block, randomPosition, Quaternion.identity);

		}
	}

}
