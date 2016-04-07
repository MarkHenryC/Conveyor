using UnityEngine;
using System.Collections;

public class Puck : MonoBehaviour {
    Vector3 pos;
    Rigidbody myRigidbody;

    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
        pos = transform.position;
    }

    public void Restart()
    {
        myRigidbody.useGravity = false;
        myRigidbody.isKinematic = true;
        transform.position = pos;
        myRigidbody.useGravity = true;
        myRigidbody.isKinematic = false;

    }

}
