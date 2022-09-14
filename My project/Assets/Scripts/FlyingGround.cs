using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingGround : MonoBehaviour
{
    Transform groundTransform;

    void Start()
    {
        groundTransform = this.transform;
    }

    void Update()
    {
        transform.position += new Vector3(0, .01f, 0);
    }
}
