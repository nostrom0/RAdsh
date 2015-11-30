using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour {
	public Animation an;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("a")){
			an.Play("attack0");
		}
		if(Input.GetKeyDown("q")){
			an.Play("attack1");
		}
		if(Input.GetKeyDown("d")){
			an.Play("death");
		}
		if(Input.GetKeyDown("i")){
			an.Play("idle0");
		}
		if(Input.GetKeyDown("k")){
			an.Play("idle1");
		}
		if(Input.GetKeyDown("r")){
			an.Play("run");
		}
		if(Input.GetKeyDown("s")){
			an.Play("skill0");
		}
		if(Input.GetKeyDown("w")){
			an.Play("wound");
		}
	}
}
