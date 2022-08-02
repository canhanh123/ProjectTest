using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerMove : MonoBehaviour
{
    public Joystick joystick;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float jumForce;
    [SerializeField]
    private  Animator amin;

    Vector3 inputVector;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Application.targetFrameRate = 60;
        amin = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float h = CrossPlatformInputManager.GetAxis("Horizontal");
        //float v = CrossPlatformInputManager.GetAxis("Vertical");
        float h = joystick.Horizontal;
        float v = joystick.Vertical;
        Vector3 movement = new Vector3(h, 0, v).normalized;
      
        if(h == 0 && v == 0)
        {
            amin.SetBool("Run", false);
        }
        else
        {
            amin.SetBool("Run", true);
        }
        if (movement == Vector3.zero)
        {
            return;
        }
        Quaternion targetRotation = Quaternion.LookRotation(movement);
        targetRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 360 * Time.deltaTime); ;
        rb.MovePosition(rb.position+movement*speed*Time.fixedDeltaTime);
        rb.MoveRotation(targetRotation);
        rb.velocity = inputVector;
        // inputVector = new Vector3(Input.GetAxis("Horizontal")* speed,rb.velocity.y , Input.GetAxis("Vertical")  * speed);
        //Quaternion targetRotation = Quaternion.LookRotation()
        // Vector3 move = new Vector3(h, 0, v);
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumForce,ForceMode.Impulse);
        }
    }
    private void Update()
    {
        
    }
}
