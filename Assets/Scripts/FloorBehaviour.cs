using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehaviour : MonoBehaviour
{

    public float rotationSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Input.GetAxis("Horizontal") * rotationSpeed, 0, Input.GetAxis("Vertical") * rotationSpeed);
    }
}