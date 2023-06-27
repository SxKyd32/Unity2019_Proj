using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class testAutoWalk : MonoBehaviour
{
    private NavMeshAgent _nav;

    // Start is called before the first frame update
    void Start()
    {
        _nav = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                _nav.SetDestination(hit.point);
            }
        }
    }
}
