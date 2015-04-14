using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float speed = 5;
	public GameObject dan;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("m")){
			Instantiate(dan,transform.position,Quaternion.identity);

		}

	}
}
