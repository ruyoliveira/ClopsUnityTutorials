using UnityEngine;
using System.Collections;

public class BulletAI : MonoBehaviour {
	
	public float speed;//velocidade movimento

	// Use this for initialization
	void Start () {
		//Movimenta para na vertical
		Vector3 newVelocity = Vector3.zero;//inicializa vetor velocidade
		newVelocity.y = speed;//atribui o valor de speed a compontente Y da velocidade
		rigidbody.velocity = newVelocity;//adiciona velocidade vertical onstante ao Game Object
	}
	
	// Update is called once per frame
	void Update () {
	}
	//Evento lancado quando o gameobject "colide" com algo
	void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.name!="ship"){//Verifica se o Game Object colidido é o ship
			Destroy(gameObject);
			
		}
	}

}
