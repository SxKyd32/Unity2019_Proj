using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float RotateSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.up.y > 0 && this.transform.up.y <= 10)
            if (Input.GetKey(KeyCode.W))
            {
                print("Moving W");
                if (MoveSpeed <= 30)
                {
                    MoveSpeed = MoveSpeed + 10 * Time.deltaTime;
                }
                this.transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);
                if (Input.GetKey(KeyCode.A))
                {
                    this.transform.Rotate(Vector3.up * Time.deltaTime * -RotateSpeed);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    this.transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed);
                }

            }
            else if (Input.GetKey(KeyCode.S))
            {
                print("Moving S");

                MoveSpeed = 5;

                this.transform.Translate(Vector3.forward * Time.deltaTime * -MoveSpeed);
                if (Input.GetKey(KeyCode.A))
                {
                    this.transform.Rotate(Vector3.up * Time.deltaTime * -RotateSpeed);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    this.transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed);
                }
            }
            else if (Input.GetKey(KeyCode.A))
            {
                MoveSpeed = 5;
                this.transform.Translate(Vector3.forward * Time.deltaTime * 0.1f * MoveSpeed);
                this.transform.Rotate(Vector3.up * Time.deltaTime * -RotateSpeed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                MoveSpeed = 5;
                this.transform.Translate(Vector3.forward * Time.deltaTime * 0.1f * MoveSpeed);
                this.transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                MoveSpeed = 5;
                this.transform.Translate(Vector3.forward * Time.deltaTime * 0.1f * MoveSpeed);
                this.transform.Rotate(Vector3.up * Time.deltaTime * -RotateSpeed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                MoveSpeed = 5;
                this.transform.Translate(Vector3.forward * Time.deltaTime * 0.1f * MoveSpeed);
                this.transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed);
            }
    }
}
