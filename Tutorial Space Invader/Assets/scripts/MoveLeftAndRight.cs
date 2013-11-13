using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour {
	
	public float speed = 1.0f;//velocidade do movimento

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Movimenta para os lados
		Vector3 newPosition = transform.position;//guarda posicao atual
		newPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;//Recebe a entrada do teclado e calcula nova posocao
		transform.position = newPosition;//atribui nova posicao ao Game Object
	}
	//Evento lancado quando o gameobject "colide" com algo
	void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.tag=="enemy"){//Verifica se o objeto colidido é um inimigo
			Destroy(gameObject);//destroi objeto colidido
			
		}
	}
}
