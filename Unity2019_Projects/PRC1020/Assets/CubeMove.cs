using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private Rigidbody cubeRigid;
    public GameObject cube;
    public int force = 5;

    // int flag = 0;


    // Start is called before the first frame update
    void Start()
    {
        //右x 上y 负z
        cubeRigid = cube.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow) /*&& flag == 0*/)
        {
            cubeRigid.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
            // flag = 1;

            Debug.Log("检测到向上按键");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            cube.transform.Translate(Vector3.right);

            Debug.Log("检测到向右按键");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            cubeRigid.MovePosition(new Vector3(10, 1, 0));
            cubeRigid.MoveRotation(Quaternion.Euler(new Vector3(45, 0, 0)));

            Debug.Log("检测到空格");
        }
    }
}
