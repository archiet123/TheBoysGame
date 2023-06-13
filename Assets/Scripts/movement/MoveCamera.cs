using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform CameraPosition;

    public void Update()
    {
        transform.position = CameraPosition.position;

    }
}
