using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public GameObject quandich;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate(quandich,transform.position,Quaternion.identity);
	}
}
