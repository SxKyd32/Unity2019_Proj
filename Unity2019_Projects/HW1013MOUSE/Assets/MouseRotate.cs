using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    // 旋转速度
    public float rotSpeed = 4f;

    // 旋转开关
    public bool RoteX = true;
    public bool RoteY = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        if (RoteX == true)
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            transform.RotateAround(Vector3.up, -rotX);
        }

        if (RoteY == true)
        {
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
            transform.RotateAround(Vector3.right, rotY);
        }
    }



}
