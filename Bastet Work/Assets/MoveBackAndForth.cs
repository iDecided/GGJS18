using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(-6, Mathf.PingPong(Time.time * 1.75f, 4) - 2, 0);
	}
}
