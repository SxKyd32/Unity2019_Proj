using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 获得鼠标当前位置的X,Y
        float mouseX = Input.GetAxis("Mouse X") * moveSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * moveSpeed;

        Camera.main.transform.localRotation = Camera.main.transform.localRotation * Quaternion.Euler(-mouseY, mouseX, 0);
    

        //// 鼠标在Y轴上的运动
        //Camera.main.transform.localRotation = Camera.main.transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
        //// 鼠标在X轴上的运动
        //transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0);
    }
}
