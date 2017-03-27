using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara2 : MonoBehaviour {
    public Marco Dragon;
    private Vector3 LastP;
    private float movement;


	// Use this for initialization
	void Start () {
        Dragon = FindObjectOfType<Marco>();
        LastP = Dragon.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        movement = Dragon.transform.position.x - LastP.x;
        transform.position = new Vector3(transform.position.x + movement, transform.position.y, transform.position.z);

        LastP = Dragon.transform.position;

		
	}
}
