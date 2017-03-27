using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Límites : MonoBehaviour {
    public float YMin;
    public float YMax;
    public Transform Marco;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(Marco.position.y, YMin, YMax), transform.position.z);
	}
}
