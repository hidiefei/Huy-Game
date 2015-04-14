using UnityEngine;
using System.Collections;

public class DanControl : MonoBehaviour {
	public float speed = 20;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 transform.Translate (Vector3.right * speed * Time.deltaTime);

		if (transform.position.x > 12.0f || transform.position.x < -12.0f)
			Destroy (this.gameObject);
	}
}
