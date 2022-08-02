using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
       Vector3 desirePosition = target.position+offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desirePosition, smoothSpeed);
        transform.position = smoothedPosition;
       //transform.LookAt(target);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
