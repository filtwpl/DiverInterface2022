using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForces : MonoBehaviour
{
    Rigidbody ballRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = this.GetComponent<Rigidbody>();

        // creates a randomized vector along the unit sphere
        Vector3 randomForce = 125.0f * Random.insideUnitSphere; 

        ballRigidBody.AddForce(randomForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
