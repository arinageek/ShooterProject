using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, 5.0f);
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "bird")
        {          
            Score.score += 1;
            Destroy(col.gameObject);
            Destroy(gameObject, 0.0f);
        }
    }
}
