using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnTester : MonoBehaviour {

	public GameObject Block;
	public int maxBox = 3;
	public int maxX = 30f;
	public int minX = 0f;
	public int maxY = 30f;
	public int minY = 30f;


	private Vector2 originPosition;



	// Use this for initialization
	void Start () {

		originPosition = transform.position;
		Spawn ();
	}

	void Spawn()
	{
		for (int i = 0; i < maxBox; i++)
		{
			Vector2 randomPosition = originPosition + new Vector2 (Random.Range(minX, maxX), Random.Range (minY, maxY));
			Instantiate (Block, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
	}

}
