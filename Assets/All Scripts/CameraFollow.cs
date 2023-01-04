using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public SphereMotion Player;
    public Vector3 PlatformToCameraOffset;
    public float Speed;

    void Update()
    {
        if (Player.CurrenPlatform == null) return;

        Vector3 targetPosition = Player.CurrenPlatform.transform.position + PlatformToCameraOffset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
    }
}
