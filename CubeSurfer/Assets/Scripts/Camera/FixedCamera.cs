using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour
{
    [SerializeField] GameObject targetGameObject;

    [Range(-20, 20)]
    [SerializeField] float xDistance, yDistance;
    [Range(-10, 10)]
    [SerializeField] float zDistance;
    [Range(0, 180)]
    [SerializeField] float xRotate, yRotate, zRotate;
    void FixedUpdate()
    {
        float x = targetGameObject.transform.position.x;
        float z = targetGameObject.transform.position.z;
        transform.rotation = Quaternion.Euler(xRotate, yRotate, zRotate);
        transform.position = new Vector3(x + xDistance, yDistance, z + zDistance);
    }
}
