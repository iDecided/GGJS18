using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Controller : MonoBehaviour {

	[SerializeField]
	Animator bossAnim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (UnityEngine.Input.GetKeyDown(KeyCode.Space)) {
			bossAnim.SetTrigger ("StartAttack");
			Invoke ("stopFiring", 2);
		} 
	}

	void stopFiring (){
		bossAnim.SetTrigger ("DoneFiring");
	}
}
