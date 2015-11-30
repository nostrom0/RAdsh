using UnityEngine;
using System.Collections;

public class empezar : MonoBehaviour {

	public void btnstart(){
		Application.LoadLevel("ZombieBUeno");
	}

	public void btncreditos(){
		Application.LoadLevel("Creditos");
	}
	public void btnvolver(){
		Application.LoadLevel("Inicio");
	}
}
