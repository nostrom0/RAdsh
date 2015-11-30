using UnityEngine;
using System.Collections;

public class SiguienteAnime : MonoBehaviour {
	public Animation an;
	static int cont;
	// Use this for initialization
	void Start () {
		cont = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (cont == 8) {
			cont = 0;
		}
		switch (cont) {
		case 0:
			{
				an.Play ("idle0");
				break;
			}
		case 1:
			{
				an.Play ("attack0");
				break;
			}
		case 2:
			{
				an.Play ("skill0");
				cont++;
				break;
			}
		case 3:
			{
				an.Play ("wound");
				break;
			}
		case 4:
			{
				an.Play ("run");
				break;
			}
		case 5:
			{
				an.Play ("idle1");
				break;
			}
		case 6:
			{
				an.Play ("attack1");
				break;
			}
		case 7:
			{
				an.Play ("death");
				break;
			}
		}//fin case
	}

	public void EventoBoton(){
		cont++;
	}
}
