using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // prints to console if ball hits floor
        if (this.transform.position.y == 0.5f) {
            Debug.Log("hit the floor");
        }
    }
}
