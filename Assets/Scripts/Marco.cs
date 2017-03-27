using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marco : MonoBehaviour {
    public float Speed;
    public float Jump;
    private Rigidbody2D Body;
    public float YMin;
    public float YMax;
    


	// Use this for initialization
	void Start () {
        Body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Body.velocity = new Vector2(Speed, Body.velocity.y);
        if (Input.GetKey(KeyCode.Space))
        {
            Body.velocity = new Vector2(Body.velocity.x, Jump);
        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, YMin, YMax), transform.position.z);
		
	}
}
