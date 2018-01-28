using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class bossController : MonoBehaviour {

	Animator anim;
	GameObject laserEye;
	Vector3 firingVector;

	public GameObject player;

	bool drawLaser = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		laserEye = this.gameObject.transform.GetChild(0).gameObject;
		//InvokeRepeating ("beamAttack");
	}
	
	// Update is called once per frame
	void Update () {
		if (UnityEngine.Input.GetKeyDown(KeyCode.Space)) {
			beamAttack ();
			drawLaser = true;
		} 
	}

	void OnDrawGizmos() {
		if(drawLaser) {
			Gizmos.color = Color.red;
			Gizmos.DrawLine (laserEye.transform.position, firingVector);
		}
	}

	void beamAttack (){
		firingVector = player.transform.position;
		anim.SetTrigger("StartAttack");
		Invoke("stopFiring", 3);
	}

	void stopFiring (){
		anim.SetTrigger ("DoneFiring");
		drawLaser = false;
		firingVector = new Vector3 (0, 0, 0);
	}
}
