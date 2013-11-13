using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {
	public GameObject enemy;
	public int verticalLimit=3;//quantidade de inimigos na vertical
	public int horizontalLimit=10;//quantidade de inimigos na horizontal

	// Use this for initialization
	void Start () {
		//Instancia inimigos baseado na quantidade limite vertical e horizontal
		for (int y = 0; y <  verticalLimit; y++) {
		for (int x = -horizontalLimit; x <  horizontalLimit; x+=2) {
			Instantiate(enemy, new Vector3(x, 8+(y*2), 0), Quaternion.identity);
		}
	}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
