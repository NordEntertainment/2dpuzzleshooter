using UnityEngine;
using System.Collections;

public class TestLevel : SpawnTester {

	public SpawnTester ST;

	void Start () {

		for (int i = 0; i < 3; i++)
		{
			RedCube ();
		}
		for (int i = 0; i < 2; i++)
		{
			YellowCube ();
		}
		for (int i = 0; i < 5; i++)
		{
			GreenCube ();
		}
	
		
	}
}
