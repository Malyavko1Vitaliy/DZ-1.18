using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Transform Level;
    public float Sensitive;
    private Vector3 _previosMousePosition;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previosMousePosition;
            Level.Rotate(0, -delta.x * Sensitive, 0);
        }
        
        _previosMousePosition = Input.mousePosition;
    }
}
