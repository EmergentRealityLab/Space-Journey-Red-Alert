using UnityEngine;
using System.Collections;

public class Engines : MonoBehaviour {

    [Range(-1f, 1f)] public float pitch;
    [Range(-1f, 1f)] public float yaw;
    [Range(-1f, 1f)] public float roll;
    [Range(-1, 1)]    public float thrust;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(pitch, yaw, roll);
        rb.AddForce(transform.forward * thrust);
	}
}
