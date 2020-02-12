using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    [SerializeField] private float speed = 22f;

    void FixedUpdate()
    {
        float angle = Time.deltaTime * speed;
        transform.Rotate(angle, angle, angle);
    }
}


