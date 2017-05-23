using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public GameObject obj;
    private Rigidbody rb;
    private Transform trans;

    public float speed;

	// Use this for initialization
	void Start () {
        trans = obj.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        trans.Rotate(transform.up * Time.deltaTime * speed);
	}
}
