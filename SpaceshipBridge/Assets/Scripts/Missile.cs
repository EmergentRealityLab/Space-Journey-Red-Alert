using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {

    [Range(-1f, 1f)]
    public float pitch;
    [Range(-1f, 1f)]
    public float yaw;

    float vel = 10f;

    Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        pitch = -1 * Input.GetAxis("Vertical");
        yaw = -1*Input.GetAxis("Horizontal");
        transform.Rotate(pitch, 0, yaw);
        rb.velocity = transform.up * vel;
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
