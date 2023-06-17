using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(0.0f, 0.1f, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(0.0f, -0.1f, 0.0f, Space.Self);
        }
        // if (Input.GetKey(KeyCode.W))
        // {
        //     rb.transform.Rotate(-0.1f, 0.0f, 0.0f, Space.Self);
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     rb.transform.Rotate(0.1f, 0.0f, 0.0f, Space.Self);
        // }
    }
}
