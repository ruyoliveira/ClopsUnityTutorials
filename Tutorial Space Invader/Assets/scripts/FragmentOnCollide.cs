using UnityEngine;
using System.Collections;

public class FragmentOnCollide : MonoBehaviour {
	public int nPieces=10;
	public GameObject piece;
	public float explosionForce;
	public float spawnRadius = 1.0f;
		

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Evento lancado quando o gameobject "colide" com algo
	void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.tag=="bulletShip"){//Verifica se o Game Object colidido é o ship
			
			GameObject pieceInstance;
			//instancia fragmento emissor de som
			pieceInstance = Instantiate(piece,transform.position + Random.insideUnitSphere*spawnRadius,transform.rotation) as GameObject;
			pieceInstance.rigidbody.AddExplosionForce(explosionForce,transform.position,spawnRadius);//alica forca de explosao os fragmentos
			pieceInstance.audio.Play();
			
			//instancia os fragmentos
			for(int i=0;i < nPieces; i++)
			{
				pieceInstance = Instantiate(piece,transform.position + Random.insideUnitSphere*spawnRadius,transform.rotation) as GameObject;
				pieceInstance.rigidbody.AddExplosionForce(explosionForce,transform.position,spawnRadius);//alica forca de explosao os fragmentos
			}
			Destroy(gameObject);
		}
	}
}
