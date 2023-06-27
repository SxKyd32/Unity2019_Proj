using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxChoice : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 startPostion;
    Vector3 endPosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {



        if (Input.GetMouseButtonDown(0))
        {
            startPostion = Input.mousePosition;
            Debug.Log(startPostion);
        }
        if (Input.GetMouseButtonUp(0))
        {
            endPosition = Input.mousePosition;
            Debug.Log(endPosition);
        }
        GUI.Box(new Rect(startPostion.x, startPostion.y, endPosition.x, endPosition.y), "");

    }


}