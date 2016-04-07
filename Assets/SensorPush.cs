using UnityEngine;

public class SensorPush : MonoBehaviour
{
    public float strength = 20;

void Start () {

}

void Update () {

}

void OnTriggerEnter (Collider other) {
    //Destroy(other.gameObject);
    other.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * strength, ForceMode.Impulse);
}
}
