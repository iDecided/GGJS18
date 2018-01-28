using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class bossController : MonoBehaviour {

	Animator anim;
	GameObject laserEye;
	Vector3 firingVector;
	bool drawLaser = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		laserEye = this.gameObject.transform.GetChild(0).gameObject;
		//InvokeRepeating ("beamAttack");
	}
	
	// Update is called once per frame
	void Update () {
		if (UnityEngine.Input.GetKeyDown(KeyCode.G)) {
			beamAttack ();
			drawLaser = true;
		}
		if (UnityEngine.Input.GetKeyDown(KeyCode.F)) {
			longSwipeAttack ();
		} 
	}

	void OnDrawGizmos() {
		if(drawLaser) {
			Gizmos.color = Color.red;
			Gizmos.DrawLine (laserEye.transform.position, firingVector);
		}
	}

	void beamAttack (){
		firingVector = new Vector3(-10, laserEye.transform.position.y, laserEye.transform.position.z);
		anim.SetTrigger("ChargeAttack");
		Invoke("stopFiring", 3);
	}

	void stopFiring (){
		anim.SetTrigger ("DoneFiring");
		drawLaser = false;
		firingVector = new Vector3 (0, 0, 0);
	}

	void longSwipeAttack() {
		anim.SetTrigger("LongSwipeAttack");
	}
}
