using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
	public float speed = 2; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("v"))
			transform.Translate (Vector3.left * speed * Time.deltaTime);
	}
}
