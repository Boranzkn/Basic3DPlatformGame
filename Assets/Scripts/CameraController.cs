using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector3 offset = new Vector3(0,1,-5);

    void Update()
    {
        this.transform .position = transform.position + offset;
    }
}
