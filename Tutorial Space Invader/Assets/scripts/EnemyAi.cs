using UnityEngine;
using System.Collections;

public class EnemyAi : MonoBehaviour {
	public float speed = 1.0f;//velocidade
	public int sense=1;//sentido do movimento
	public int  limiteMov = 10;//limite de deslocamento
	public Vector3 posInicial;//posicao inicial
	
	// Use this for initialization
	void Start () {
		posInicial=transform.position;//guarda a posicao inicial do inimigo
		
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		
		newPosition.x += sense*speed * Time.deltaTime;//deslocamento horizontal
		
		if(sense==1)//caso sentido 1
		{
			if(transform.position.x-posInicial.x>limiteMov*sense)//se deslocamento for maior que o limite
			{
				sense*=-1;//inverte o sentido
				newPosition.y -= speed;//deslocamento vertical
			}
		}
		else{//caso sentido contrario
			if(transform.position.x-posInicial.x<limiteMov*sense)//se deslocamento for maior que o limite
			{
				sense*=-1;//inverte o sentido
				newPosition.y -= speed;//deslocamento vertical
			}
		}
		
		transform.position = newPosition;//atualiza posicao
	}
	
}

