using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform followTarget;
    [SerializeField] private Vector3 difference; // Kamera ile FollowPoint arasindaki farka esit olacak

    private void LateUpdate()
    {
        transform.position = followTarget.position + difference;
        transform.LookAt(followTarget);
    }
}
