using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballBehavior : MonoBehaviour
{
    private Rigidbody cannonballRb;
    public float upForce;
    public float forwardForce;

    // Start is called before the first frame update
    void Start()
    {
        cannonballRb = GetComponent<Rigidbody>();
        cannonballRb.AddForce(Vector3.up * upForce + Vector3.forward * forwardForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
