using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelControl : MonoBehaviour
{
    public WheelCollider frontleftWheelCollider;
    public WheelCollider frontrightWheelCollider;

    public GameObject frontleftWheel;
    public GameObject frontrightWheel;

    public Rigidbody car;

    private float angle;
    private int force;



    // Start is called before the first frame update
    void Start()
    {
        force = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        //车轮碰撞器旋转
        if (Input.GetKey(KeyCode.W))
        {
            frontleftWheelCollider.motorTorque = Input.GetAxisRaw("Vertical") * 10f;
            car.AddForce(new Vector3(0, 0, force), ForceMode.Force);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            frontrightWheelCollider.motorTorque = Input.GetAxisRaw("Vertical") * 10f;
            car.AddForce(new Vector3(0, 0, -force), ForceMode.Force);

        }
        frontleftWheelCollider.steerAngle = Input.GetAxisRaw("Horizontal") * 30f;
        frontleftWheel.transform.Rotate(0, Input.GetAxisRaw("Horizontal") * 30f * Time.deltaTime, 0);


        frontrightWheelCollider.steerAngle = Input.GetAxisRaw("Horizontal") * 30f;
        frontrightWheel.transform.Rotate(0, Input.GetAxisRaw("Horizontal") * 30f * Time.deltaTime, 0);
    }
}
