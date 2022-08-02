using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TestDotween : MonoBehaviour
{
    [SerializeField]
    private int duration;
    private Transform[] pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            transform.DOLookAt(new Vector3(transform.position.x, transform.rotation.y*180f, transform.position.z), duration, AxisConstraint.Y, Vector3.zero);
            transform.DORotate(new Vector3(0f, 180f, 0f), duration, RotateMode.Fast);
        }
        
    }
}
